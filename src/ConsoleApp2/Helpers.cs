using System.Drawing;

namespace MandelbrotZoomer.Businesslayer
{
    public class Helpers
    {
        private static readonly double colorrange24 = 256d * 256d * 256d;
        public static Bitmap BitmapConverter(int[] data, int width, int height, int colorshift, int colorrange, int iterations)
        {
            Bitmap bitmap = new Bitmap(width, height);
            double absoluteColorRange = colorrange24 / 64d * colorrange;
            double absoluteColorShift = colorrange24 / 64d * colorshift;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double color = data[x + y * width] * absoluteColorRange / iterations + absoluteColorShift;
                    bitmap.SetPixel(x, y, Color.FromArgb(255, data[x + y * width] == iterations ?  Color.Black: Color.FromArgb((int)color))); 
                }
            }
            return bitmap;
        }
    }
}
