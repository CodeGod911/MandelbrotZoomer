using MandelbrotZoomer.;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MandelbrotZoomer.Presentation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pbMandelbrot.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Render_ValueChanged(object sender, EventArgs e)
        {
            Mandelbrot.CompileKernel(false);
            int width = pbMandelbrot.Size.Width;
            int height = pbMandelbrot.Size.Height;
            int[] result = new int[width * height];
            Mandelbrot.CalcCPU(result, width, height, (float)numX.Value, (float)numY.Value, (float)numZ.Value, 100);
            Bitmap mandelbrot = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                    mandelbrot.SetPixel(x, y, result[x + y * width] < 100 ? Color.White : Color.Black);
            }
            pbMandelbrot.Image = mandelbrot;
        }
    }
}
