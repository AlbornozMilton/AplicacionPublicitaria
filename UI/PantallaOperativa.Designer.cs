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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenCamp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ImagenCamp
            // 
            this.pictureBox_ImagenCamp.Location = new System.Drawing.Point(25, 22);
            this.pictureBox_ImagenCamp.Name = "pictureBox_ImagenCamp";
            this.pictureBox_ImagenCamp.Size = new System.Drawing.Size(736, 338);
            this.pictureBox_ImagenCamp.TabIndex = 0;
            this.pictureBox_ImagenCamp.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(736, 20);
            this.textBox1.TabIndex = 2;
            // 
            // PantallaOperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox_ImagenCamp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaOperativa";
            this.Text = "PantallaOperativa";
            this.Load += new System.EventHandler(this.PantallaOperativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenCamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ImagenCamp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer_ImagenesCampania;
        private System.Windows.Forms.Timer timer1;
    }
}