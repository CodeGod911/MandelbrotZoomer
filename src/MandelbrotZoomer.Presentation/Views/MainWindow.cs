using MandelbrotZoomer.Businesslayer.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MandelbrotZoomer.Presentation.Views
{

    public partial class MainWindow : Form
    {
        MainWindowController controller = new MainWindowController();
        Bitmap currentPicture;

        public MainWindow()
        {
            InitializeComponent();
        }

        bool deactivateRenderValueChanged = false;
        private void Render_ValueChanged(object sender, EventArgs e)
        {

            if (!deactivateRenderValueChanged)
            {
                if (pbMandelbrot.Size.Width > 0 && pbMandelbrot.Size.Height > 0)
                {
                    var mandelbrot = controller.CalcMandelbrotBmp(
                            pbMandelbrot.Size.Width,
                            pbMandelbrot.Size.Height,
                            (double)numX.Value,
                            (double)numY.Value,
                            (double)numZ.Value,
                            (int)numIterationen.Value,
                            tbColorShift.Value,
                            tbColorRange.Value
                        );

                    currentPicture = mandelbrot;
                    pbMandelbrot.Image = mandelbrot;
                }


                numX.Increment = 1m / numZ.Value;
                numY.Increment = 1m / numZ.Value;
                numZ.Increment = numZ.Value / 2;
            }
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                DefaultExt = "mb",
                AddExtension = true,
                Filter = "Mandelbrot Location (*.mb)|*.mb"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                controller.SaveMandelbrotPostition(saveFileDialog.FileName, numX.Value, numY.Value, numZ.Value);

        }

        private void btScreenshot_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                DefaultExt = "jpg",
                AddExtension = true,
                Filter = "Jpeg (*.jpg)|*.jpg"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                controller.SaveScreenshot(saveFileDialog.FileName, currentPicture);

        }

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                DefaultExt = "mb",
                AddExtension = true,
                Filter = "Mandelbrot Location (*.mb)|*.mb"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var location = controller.LoadMandelbrotPostition(openFileDialog.FileName);
                numX.Value = location.OffsetX;
                numY.Value = location.OffsetY;
                numZ.Value = location.ZoomFactor;
            }
        }

        private void pbMandelbrot_Click(object sender, MouseEventArgs e)
        {
            if (pbMandelbrot.Image != null)
            {
                var p = pbMandelbrot.PointToClient(this.PointToScreen(e.Location));
                var point = new Point(p.X, p.Y);
                var width = pbMandelbrot.Image.Width;
                var height = pbMandelbrot.Image.Height;


                decimal rangeH = 1.5m / numZ.Value;
                decimal h_a = (-0.5m + numX.Value - rangeH);
                decimal h_b = (-0.5m + numX.Value + rangeH);

                decimal rangeV = 1m / numZ.Value;
                decimal v_a = (numY.Value + rangeV);
                decimal v_b = (numY.Value - rangeV);

                int index = point.X + point.Y * width;
                int img_x = index % width;
                int img_y = index / width;

                decimal x = h_a + img_x * (h_b - h_a) / width + 0.5m;
                decimal y = v_a + img_y * (v_b - v_a) / height;

                deactivateRenderValueChanged = true;
                numX.Value = x < numX.Maximum ? (x > numX.Minimum ? x : numX.Minimum) : numX.Maximum;
                numY.Value = y < numY.Maximum ? (y > numY.Minimum ? y : numY.Minimum) : numY.Maximum;
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        if (numZ.Maximum >= numZ.Value + numZ.Increment)
                            numZ.Value += numZ.Increment;
                        break;

                    case MouseButtons.Right:
                        if (numZ.Minimum <= numZ.Value - numZ.Increment)
                            numZ.Value -= numZ.Increment;
                        else if (numZ.Value != 1)
                            numZ.Value = 1;
                        break;
                }
                deactivateRenderValueChanged = false;
                Render_ValueChanged(sender, e);
            }
        }

        private void tsmPrint_Click(object sender, EventArgs e)
        {
            controller.PrintMandelbrot(
                    (double)numX.Value,
                    (double)numY.Value,
                    (double)numZ.Value,
                    (int)numIterationen.Value,
                    tbColorShift.Value,
                    tbColorRange.Value
                );
        }

    }
}
