using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MandelbrotZoomer.DataAccessLayer
{
    public class PrintManager
    {
        public void PrintImage(Bitmap bmp)
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (object sender, PrintPageEventArgs e) =>
            {
                float newWidth = bmp.Width * 100 / bmp.HorizontalResolution;
                float newHeight = bmp.Height * 100 / bmp.VerticalResolution;

                float widthFactor = newWidth / e.MarginBounds.Width;
                float heightFactor = newHeight / e.MarginBounds.Height;

                if (widthFactor > 1 | heightFactor > 1)
                {
                    if (widthFactor > heightFactor)
                    {
                        newWidth = newWidth / widthFactor;
                        newHeight = newHeight / widthFactor;
                    }
                    else
                    {
                        newWidth = newWidth / heightFactor;
                        newHeight = newHeight / heightFactor;
                    }
                }
                e.Graphics.DrawImage(bmp, 0, 0, (int)newWidth, (int)newHeight);
            };

            if (new PrintDialog() { Document = pd }.ShowDialog() == DialogResult.OK)
                    pd.Print();
        }
    }
}
