
namespace MandelbrotZoomer.Presentation.Views
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.btRender = new System.Windows.Forms.Button();
            this.numIterationen = new System.Windows.Forms.NumericUpDown();
            this.pbMandelbrot = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tbColorRange = new System.Windows.Forms.TrackBar();
            this.lblColorshift = new System.Windows.Forms.Label();
            this.tbColorShift = new System.Windows.Forms.TrackBar();
            this.pnlPicturebox = new System.Windows.Forms.Panel();
            this.btScreenshot = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblOffsetY = new System.Windows.Forms.Label();
            this.lblIteration = new System.Windows.Forms.Label();
            this.lblOffsetX = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrint = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterationen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMandelbrot)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorShift)).BeginInit();
            this.pnlPicturebox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numZ
            // 
            this.numZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numZ.Location = new System.Drawing.Point(1726, 900);
            this.numZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numZ.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(180, 26);
            this.numZ.TabIndex = 1;
            this.numZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numZ.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // numY
            // 
            this.numY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numY.DecimalPlaces = 50;
            this.numY.Location = new System.Drawing.Point(1537, 900);
            this.numY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(180, 26);
            this.numY.TabIndex = 2;
            this.numY.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // numX
            // 
            this.numX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numX.DecimalPlaces = 50;
            this.numX.Location = new System.Drawing.Point(1348, 900);
            this.numX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(180, 26);
            this.numX.TabIndex = 3;
            this.numX.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // btRender
            // 
            this.btRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRender.Location = new System.Drawing.Point(18, 895);
            this.btRender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRender.Name = "btRender";
            this.btRender.Size = new System.Drawing.Size(112, 35);
            this.btRender.TabIndex = 4;
            this.btRender.Text = "Render";
            this.btRender.UseVisualStyleBackColor = true;
            this.btRender.Click += new System.EventHandler(this.Render_ValueChanged);
            // 
            // numIterationen
            // 
            this.numIterationen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numIterationen.Location = new System.Drawing.Point(1159, 900);
            this.numIterationen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numIterationen.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numIterationen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIterationen.Name = "numIterationen";
            this.numIterationen.Size = new System.Drawing.Size(180, 26);
            this.numIterationen.TabIndex = 5;
            this.numIterationen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numIterationen.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // pbMandelbrot
            // 
            this.pbMandelbrot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMandelbrot.Location = new System.Drawing.Point(0, 0);
            this.pbMandelbrot.Margin = new System.Windows.Forms.Padding(0);
            this.pbMandelbrot.Name = "pbMandelbrot";
            this.pbMandelbrot.Size = new System.Drawing.Size(1915, 864);
            this.pbMandelbrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMandelbrot.TabIndex = 0;
            this.pbMandelbrot.TabStop = false;
            this.pbMandelbrot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMandelbrot_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbColorRange);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblColorshift);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbColorShift);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlPicturebox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btScreenshot);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblZoom);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblOffsetY);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblIteration);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblOffsetX);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.numZ);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btRender);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.numIterationen);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.numY);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.numX);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1924, 949);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1924, 983);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 873);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Colorrange";
            // 
            // tbColorRange
            // 
            this.tbColorRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbColorRange.Location = new System.Drawing.Point(444, 895);
            this.tbColorRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbColorRange.Maximum = 64;
            this.tbColorRange.Name = "tbColorRange";
            this.tbColorRange.Size = new System.Drawing.Size(346, 69);
            this.tbColorRange.TabIndex = 14;
            this.tbColorRange.Value = 64;
            this.tbColorRange.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // lblColorshift
            // 
            this.lblColorshift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorshift.AutoSize = true;
            this.lblColorshift.Location = new System.Drawing.Point(808, 873);
            this.lblColorshift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColorshift.Name = "lblColorshift";
            this.lblColorshift.Size = new System.Drawing.Size(76, 20);
            this.lblColorshift.TabIndex = 13;
            this.lblColorshift.Text = "Colorshift";
            // 
            // tbColorShift
            // 
            this.tbColorShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbColorShift.LargeChange = 1;
            this.tbColorShift.Location = new System.Drawing.Point(799, 895);
            this.tbColorShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbColorShift.Maximum = 64;
            this.tbColorShift.Name = "tbColorShift";
            this.tbColorShift.Size = new System.Drawing.Size(346, 69);
            this.tbColorShift.TabIndex = 12;
            this.tbColorShift.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // pnlPicturebox
            // 
            this.pnlPicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPicturebox.Controls.Add(this.pbMandelbrot);
            this.pnlPicturebox.Location = new System.Drawing.Point(4, 5);
            this.pnlPicturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPicturebox.Name = "pnlPicturebox";
            this.pnlPicturebox.Size = new System.Drawing.Size(1915, 864);
            this.pnlPicturebox.TabIndex = 11;
            // 
            // btScreenshot
            // 
            this.btScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btScreenshot.Location = new System.Drawing.Point(141, 895);
            this.btScreenshot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btScreenshot.Name = "btScreenshot";
            this.btScreenshot.Size = new System.Drawing.Size(112, 35);
            this.btScreenshot.TabIndex = 10;
            this.btScreenshot.Text = "Screenshot";
            this.btScreenshot.UseVisualStyleBackColor = true;
            this.btScreenshot.Click += new System.EventHandler(this.btScreenshot_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(1726, 873);
            this.lblZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(100, 20);
            this.lblZoom.TabIndex = 9;
            this.lblZoom.Text = "Zoom Factor";
            // 
            // lblOffsetY
            // 
            this.lblOffsetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOffsetY.AutoSize = true;
            this.lblOffsetY.Location = new System.Drawing.Point(1537, 873);
            this.lblOffsetY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffsetY.Name = "lblOffsetY";
            this.lblOffsetY.Size = new System.Drawing.Size(68, 20);
            this.lblOffsetY.TabIndex = 8;
            this.lblOffsetY.Text = "Offset Y";
            // 
            // lblIteration
            // 
            this.lblIteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIteration.AutoSize = true;
            this.lblIteration.Location = new System.Drawing.Point(1154, 875);
            this.lblIteration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(68, 20);
            this.lblIteration.TabIndex = 7;
            this.lblIteration.Text = "Iteration";
            // 
            // lblOffsetX
            // 
            this.lblOffsetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOffsetX.AutoSize = true;
            this.lblOffsetX.Location = new System.Drawing.Point(1344, 875);
            this.lblOffsetX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffsetX.Name = "lblOffsetX";
            this.lblOffsetX.Size = new System.Drawing.Size(68, 20);
            this.lblOffsetX.TabIndex = 6;
            this.lblOffsetX.Text = "Offset X";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(120, 34);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsMenu
            // 
            this.tsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSave,
            this.tsmLoad,
            this.tsmPrint});
            this.tsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsMenu.Image")));
            this.tsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(56, 29);
            this.tsMenu.Text = "File";
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(270, 34);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmLoad
            // 
            this.tsmLoad.Name = "tsmLoad";
            this.tsmLoad.Size = new System.Drawing.Size(270, 34);
            this.tsmLoad.Text = "Load";
            this.tsmLoad.Click += new System.EventHandler(this.tsmLoad_Click);
            // 
            // tsmPrint
            // 
            this.tsmPrint.Name = "tsmPrint";
            this.tsmPrint.Size = new System.Drawing.Size(270, 34);
            this.tsmPrint.Text = "Print";
            this.tsmPrint.Click += new System.EventHandler(this.tsmPrint_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Render_ValueChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterationen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMandelbrot)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorShift)).EndInit();
            this.pnlPicturebox.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numZ;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Button btRender;
        private System.Windows.Forms.NumericUpDown numIterationen;
        private System.Windows.Forms.PictureBox pbMandelbrot;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label lblOffsetY;
        private System.Windows.Forms.Label lblIteration;
        private System.Windows.Forms.Label lblOffsetX;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmPrint;
        private System.Windows.Forms.Button btScreenshot;
        private System.Windows.Forms.Panel pnlPicturebox;
        private System.Windows.Forms.TrackBar tbColorShift;
        private System.Windows.Forms.Label lblColorshift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbColorRange;
    }
}

