namespace UI
{
    partial class VentanaEmergente
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
			this.pbox_Icono = new System.Windows.Forms.PictureBox();
			this.lbl_Mensaje = new System.Windows.Forms.Label();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbox_Icono)).BeginInit();
			this.SuspendLayout();
			// 
			// pbox_Icono
			// 
			this.pbox_Icono.BackColor = System.Drawing.Color.Transparent;
			this.pbox_Icono.Location = new System.Drawing.Point(34, 60);
			this.pbox_Icono.Name = "pbox_Icono";
			this.pbox_Icono.Size = new System.Drawing.Size(80, 80);
			this.pbox_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbox_Icono.TabIndex = 0;
			this.pbox_Icono.TabStop = false;
			// 
			// lbl_Mensaje
			// 
			this.lbl_Mensaje.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Mensaje.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Mensaje.ForeColor = System.Drawing.Color.White;
			this.lbl_Mensaje.Location = new System.Drawing.Point(120, 50);
			this.lbl_Mensaje.Name = "lbl_Mensaje";
			this.lbl_Mensaje.Size = new System.Drawing.Size(248, 79);
			this.lbl_Mensaje.TabIndex = 1;
			this.lbl_Mensaje.Text = "Mensaje";
			this.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Aceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(157, 142);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(81, 33);
			this.btn_Aceptar.TabIndex = 20;
			this.btn_Aceptar.Text = "Aceptar";
			this.btn_Aceptar.UseVisualStyleBackColor = true;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// lbl_Titulo
			// 
			this.lbl_Titulo.AutoSize = true;
			this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Titulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
			this.lbl_Titulo.Location = new System.Drawing.Point(13, 9);
			this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Titulo.Name = "lbl_Titulo";
			this.lbl_Titulo.Size = new System.Drawing.Size(57, 18);
			this.lbl_Titulo.TabIndex = 21;
			this.lbl_Titulo.Text = "Titulo";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(90, 168);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(81, 33);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "No";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Visible = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// VentanaEmergente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(393, 196);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.lbl_Titulo);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.lbl_Mensaje);
			this.Controls.Add(this.pbox_Icono);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "VentanaEmergente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VentanaEmergente";
			this.Load += new System.EventHandler(this.VentanaEmergente_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbox_Icono)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_Icono;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Titulo;
		private System.Windows.Forms.Button btnCancelar;
	}
}