namespace UI
{
    partial class PantallaOperativa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.pictureBox_ImagenCamp = new System.Windows.Forms.PictureBox();
			this.timer_IntervaloImagen = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker_CambioCamp = new System.ComponentModel.BackgroundWorker();
			this.timer_IntervaloCamp = new System.Windows.Forms.Timer(this.components);
			this.panel_ContendorBanner = new System.Windows.Forms.Panel();
			this.panel_Banner = new System.Windows.Forms.Panel();
			this.TextoBanner = new System.Windows.Forms.Label();
			this.timer_TextoDeslizable = new System.Windows.Forms.Timer(this.components);
			this.timer_Banner = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenCamp)).BeginInit();
			this.panel_ContendorBanner.SuspendLayout();
			this.panel_Banner.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox_ImagenCamp
			// 
			this.pictureBox_ImagenCamp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox_ImagenCamp.Location = new System.Drawing.Point(0, 0);
			this.pictureBox_ImagenCamp.Name = "pictureBox_ImagenCamp";
			this.pictureBox_ImagenCamp.Size = new System.Drawing.Size(784, 442);
			this.pictureBox_ImagenCamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_ImagenCamp.TabIndex = 0;
			this.pictureBox_ImagenCamp.TabStop = false;
			// 
			// timer_IntervaloImagen
			// 
			this.timer_IntervaloImagen.Tick += new System.EventHandler(this.timer_IntervaloImagen_Tick);
			// 
			// backgroundWorker_CambioCamp
			// 
			this.backgroundWorker_CambioCamp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_CambioCamp_DoWork);
			// 
			// timer_IntervaloCamp
			// 
			this.timer_IntervaloCamp.Tick += new System.EventHandler(this.timer_IntervaloCamp_Tick);
			// 
			// panel_ContendorBanner
			// 
			this.panel_ContendorBanner.Controls.Add(this.panel_Banner);
			this.panel_ContendorBanner.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_ContendorBanner.Location = new System.Drawing.Point(0, 438);
			this.panel_ContendorBanner.Name = "panel_ContendorBanner";
			this.panel_ContendorBanner.Size = new System.Drawing.Size(784, 62);
			this.panel_ContendorBanner.TabIndex = 1;
			// 
			// panel_Banner
			// 
			this.panel_Banner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_Banner.BackColor = System.Drawing.Color.White;
			this.panel_Banner.Controls.Add(this.TextoBanner);
			this.panel_Banner.Location = new System.Drawing.Point(12, 15);
			this.panel_Banner.Name = "panel_Banner";
			this.panel_Banner.Size = new System.Drawing.Size(760, 35);
			this.panel_Banner.TabIndex = 0;
			// 
			// TextoBanner
			// 
			this.TextoBanner.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextoBanner.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextoBanner.Location = new System.Drawing.Point(188, 8);
			this.TextoBanner.Margin = new System.Windows.Forms.Padding(0);
			this.TextoBanner.Name = "TextoBanner";
			this.TextoBanner.Size = new System.Drawing.Size(10, 21);
			this.TextoBanner.TabIndex = 0;
			this.TextoBanner.Text = "label1";
			// 
			// timer_TextoDeslizable
			// 
			this.timer_TextoDeslizable.Tick += new System.EventHandler(this.timer_TextoDeslizable_Tick);
			// 
			// PantallaOperativa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(784, 500);
			this.Controls.Add(this.pictureBox_ImagenCamp);
			this.Controls.Add(this.panel_ContendorBanner);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "PantallaOperativa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PantallaOperativa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.PantallaOperativa_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PantallaOperativa_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenCamp)).EndInit();
			this.panel_ContendorBanner.ResumeLayout(false);
			this.panel_Banner.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ImagenCamp;
        private System.Windows.Forms.Timer timer_IntervaloImagen;
        private System.ComponentModel.BackgroundWorker backgroundWorker_CambioCamp;
        private System.Windows.Forms.Timer timer_IntervaloCamp;
		private System.Windows.Forms.Panel panel_ContendorBanner;
		private System.Windows.Forms.Panel panel_Banner;
		private System.Windows.Forms.Label TextoBanner;
		private System.Windows.Forms.Timer timer_TextoDeslizable;
		private System.Windows.Forms.Timer timer_Banner;
	}
}