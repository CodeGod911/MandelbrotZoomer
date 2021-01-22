using MandelbrotZoomer.Common;
using MandelbrotZoomer.DataAccessLayer;
using System.Drawing;

namespace MandelbrotZoomer.Businesslayer.Controllers
{
    public class MainWindowController
    {
        SaveFileManager saveFileManager = new SaveFileManager();
        PrintManager printManager = new PrintManager();

        public MainWindowController()
        {
            Mandelbrot.CompileKernel();
        }

        public Bitmap CalcMandelbrotBmp(int width, int height, double offsetX, double offsetY, double zoomFactor, int iterations, int colorshift, int colorrange)
        {
            var result = Mandelbrot.CalcGPU(width, height, offsetX, offsetY, zoomFactor, iterations);
            var mandelbrot = Helpers.BitmapConverter(result, width, height, colorshift, colorrange, iterations);
            return mandelbrot;
        }

        public void SaveMandelbrotPostition(string fullFileName, decimal x, decimal y, decimal z)
        {
            MandelbrotLocation m = new MandelbrotLocation()
            {
                OffsetX = x,
                OffsetY = y,
                ZoomFactor = z
            };
            saveFileManager.Save(fullFileName, m);
        }

        public void SaveScreenshot(string fileName, Bitmap currentPicture)
        {
            saveFileManager.Save(fileName, currentPicture);
        }

        public MandelbrotLocation LoadMandelbrotPostition(string fileName)
        {
            return saveFileManager.Load<MandelbrotLocation>(fileName);
        }

        public void PrintMandelbrot(double offsetX, double offsetY, double zoomFactor, int iterations, int colorshift, int colorrange)
        {
            PrintMandelbrot(4000, 2000, offsetX, offsetY, zoomFactor, iterations, colorshift, colorrange);
        }

        public void PrintMandelbrot(int width, int height, double offsetX, double offsetY, double zoomFactor, int iterations, int colorshift, int colorrange)
        {
            var result = Mandelbrot.CalcGPU(width, height, offsetX, offsetY, zoomFactor, iterations);
            var mandelbrot = Helpers.BitmapConverter(result, width, height, colorshift, colorrange, iterations);
            mandelbrot.RotateFlip(RotateFlipType.Rotate90FlipNone);
            printManager.PrintImage(mandelbrot);
        }
    }
}
