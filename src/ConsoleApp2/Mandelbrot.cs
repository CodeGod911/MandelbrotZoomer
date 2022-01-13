using ILGPU;
using ILGPU.Runtime;
using ILGPU.Runtime.CPU;
using ILGPU.Runtime.Cuda;
using System;

namespace MandelbrotZoomer.Businesslayer
{
    public class Mandelbrot
    {
        /// <summary>
        /// ILGPU kernel for Mandelbrot set.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="max_iterations"></param>
        /// <param name="output"></param>
        static void MandelbrotKernel(
            Index1 index,
            int width, int height, double h_a, double h_b, double v_a, double v_b, int max_iterations,
            ArrayView<int> output)
        {
            if (index >= output.Length)
                return;

            int img_x = index % width;
            int img_y = index / width;

            double x0 = h_a + img_x * (h_b - h_a) / width;
            double y0 = v_a + img_y * (v_b - v_a) / height;
            double x = 0.0f;
            double y = 0.0f;
            int iteration = 0;
            while ((x * x + y * y < 2 * 2) && (iteration < max_iterations))
            {
                double xtemp = x * x - y * y + x0;
                y = 2 * x * y + y0;
                x = xtemp;
                iteration += 1;
            }
            output[index] = iteration;
        }


        private static Context context;
        private static Accelerator accelerator;
        private static System.Action<Index1, int, int, double, double, double, double, int, ArrayView<int>> mandelbrot_kernel;

        public static void CompileKernel()
        {
            context = new Context();
            try 
            { 
                accelerator = new CudaAccelerator(context);
            }
            catch
            { 
                accelerator = new CPUAccelerator(context);
            }

            mandelbrot_kernel = accelerator.LoadAutoGroupedStreamKernel<
                Index1, int, int, double, double, double, double, int, ArrayView<int>>(MandelbrotKernel);
        }

        public static void Dispose()
        {
            accelerator.Dispose();
            context.Dispose();
        }

        public static int[] CalcGPU(int width, int height, double offsetx, double offsety, double zoom, int max_iterations)
        {
            int[] buffer = new int[width * height];

            int num_values = buffer.Length;
            var dev_out = accelerator.Allocate<int>(num_values);

            double rangeH = 1.5d / zoom;
            double h_a = (-0.5d + offsetx - rangeH);
            double h_b = (-0.5d + offsetx + rangeH);

            double rangeV = 1d / zoom;
            double v_a = (offsety + rangeV);
            double v_b = (offsety - rangeV);

            // Launch kernel
            mandelbrot_kernel(num_values, width, height, h_a, h_b, v_a, v_b, max_iterations, dev_out.View);
            accelerator.Synchronize();
            dev_out.CopyTo(buffer, 0, 0, num_values);

            dev_out.Dispose();
            return buffer;
        }
    }
}