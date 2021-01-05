
namespace MandelbrotZoomer.Presentation
{
    partial class Form1
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
            this.pbMandelbrot = new System.Windows.Forms.PictureBox();
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.btRender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMandelbrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMandelbrot
            // 
            this.pbMandelbrot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMandelbrot.Location = new System.Drawing.Point(12, 12);
            this.pbMandelbrot.Name = "pbMandelbrot";
            this.pbMandelbrot.Size = new System.Drawing.Size(776, 383);
            this.pbMandelbrot.TabIndex = 0;
            this.pbMandelbrot.TabStop = false;
            this.pbMandelbrot.Resize += new System.EventHandler(this.Render_ValueChanged);
            // 
            // numZ
            // 
            this.numZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numZ.Location = new System.Drawing.Point(668, 418);
            this.numZ.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(120, 20);
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
            this.numY.Location = new System.Drawing.Point(523, 418);
            this.numY.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 20);
            this.numY.TabIndex = 2;
            this.numY.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // numX
            // 
            this.numX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numX.DecimalPlaces = 50;
            this.numX.Location = new System.Drawing.Point(384, 418);
            this.numX.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 20);
            this.numX.TabIndex = 3;
            this.numX.ValueChanged += new System.EventHandler(this.Render_ValueChanged);
            // 
            // btRender
            // 
            this.btRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRender.Location = new System.Drawing.Point(12, 415);
            this.btRender.Name = "btRender";
            this.btRender.Size = new System.Drawing.Size(75, 23);
            this.btRender.TabIndex = 4;
            this.btRender.Text = "Render";
            this.btRender.UseVisualStyleBackColor = true;
            this.btRender.Click += new System.EventHandler(this.Render_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRender);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numZ);
            this.Controls.Add(this.pbMandelbrot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMandelbrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMandelbrot;
        private System.Windows.Forms.NumericUpDown numZ;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Button btRender;
    }
}

