namespace UI
{
    partial class Menu
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_EliminarCampania = new System.Windows.Forms.PictureBox();
			this.btn_EditarCampania = new System.Windows.Forms.PictureBox();
			this.btnAgregarBanner = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Reproducir = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnEditarBanner = new System.Windows.Forms.PictureBox();
			this.btnEliminarBanner = new System.Windows.Forms.PictureBox();
			this.btnFuentes = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCampania)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_EditarCampania)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAgregarBanner)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Reproducir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEditarBanner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEliminarBanner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFuentes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(16, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Menú Principal";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_EliminarCampania);
			this.groupBox1.Controls.Add(this.btn_EditarCampania);
			this.groupBox1.Controls.Add(this.btnAgregarBanner);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(20, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(411, 83);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Campañas";
			// 
			// btn_EliminarCampania
			// 
			this.btn_EliminarCampania.Image = global::UI.Properties.Resources.btn_Borrar;
			this.btn_EliminarCampania.Location = new System.Drawing.Point(237, 20);
			this.btn_EliminarCampania.Name = "btn_EliminarCampania";
			this.btn_EliminarCampania.Size = new System.Drawing.Size(50, 50);
			this.btn_EliminarCampania.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btn_EliminarCampania.TabIndex = 11;
			this.btn_EliminarCampania.TabStop = false;
			// 
			// btn_EditarCampania
			// 
			this.btn_EditarCampania.Image = global::UI.Properties.Resources.btn_Editar;
			this.btn_EditarCampania.Location = new System.Drawing.Point(135, 20);
			this.btn_EditarCampania.Name = "btn_EditarCampania";
			this.btn_EditarCampania.Size = new System.Drawing.Size(50, 50);
			this.btn_EditarCampania.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btn_EditarCampania.TabIndex = 10;
			this.btn_EditarCampania.TabStop = false;
			// 
			// btnAgregarBanner
			// 
			this.btnAgregarBanner.Image = global::UI.Properties.Resources.btn_Agregar;
			this.btnAgregarBanner.Location = new System.Drawing.Point(34, 20);
			this.btnAgregarBanner.Name = "btnAgregarBanner";
			this.btnAgregarBanner.Size = new System.Drawing.Size(50, 50);
			this.btnAgregarBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btnAgregarBanner.TabIndex = 9;
			this.btnAgregarBanner.TabStop = false;
			this.btnAgregarBanner.Click += new System.EventHandler(this.btn_AgregarCampania_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnFuentes);
			this.groupBox2.Controls.Add(this.btnEliminarBanner);
			this.groupBox2.Controls.Add(this.btnEditarBanner);
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(19, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(412, 71);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Banners";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(471, -7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 39);
			this.label2.TabIndex = 6;
			this.label2.Text = "_";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(509, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "X";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// btn_Reproducir
			// 
			this.btn_Reproducir.Image = global::UI.Properties.Resources.btn_Reproducir;
			this.btn_Reproducir.Location = new System.Drawing.Point(462, 119);
			this.btn_Reproducir.Name = "btn_Reproducir";
			this.btn_Reproducir.Size = new System.Drawing.Size(50, 50);
			this.btn_Reproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btn_Reproducir.TabIndex = 12;
			this.btn_Reproducir.TabStop = false;
			this.btn_Reproducir.Click += new System.EventHandler(this.btn_Reproducir_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::UI.Properties.Resources.btn_Agregar;
			this.pictureBox1.Location = new System.Drawing.Point(35, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnEditarBanner
			// 
			this.btnEditarBanner.Image = global::UI.Properties.Resources.btn_Editar;
			this.btnEditarBanner.Location = new System.Drawing.Point(136, 15);
			this.btnEditarBanner.Name = "btnEditarBanner";
			this.btnEditarBanner.Size = new System.Drawing.Size(50, 50);
			this.btnEditarBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btnEditarBanner.TabIndex = 11;
			this.btnEditarBanner.TabStop = false;
			this.btnEditarBanner.Click += new System.EventHandler(this.btnEditarBanner_Click);
			// 
			// btnEliminarBanner
			// 
			this.btnEliminarBanner.Image = global::UI.Properties.Resources.btn_Borrar;
			this.btnEliminarBanner.Location = new System.Drawing.Point(238, 15);
			this.btnEliminarBanner.Name = "btnEliminarBanner";
			this.btnEliminarBanner.Size = new System.Drawing.Size(50, 50);
			this.btnEliminarBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btnEliminarBanner.TabIndex = 12;
			this.btnEliminarBanner.TabStop = false;
			this.btnEliminarBanner.Click += new System.EventHandler(this.btnEliminarBanner_Click);
			// 
			// btnFuentes
			// 
			this.btnFuentes.Image = global::UI.Properties.Resources.btn_Agregar;
			this.btnFuentes.Location = new System.Drawing.Point(334, 15);
			this.btnFuentes.Name = "btnFuentes";
			this.btnFuentes.Size = new System.Drawing.Size(50, 50);
			this.btnFuentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btnFuentes.TabIndex = 13;
			this.btnFuentes.TabStop = false;
			this.btnFuentes.Click += new System.EventHandler(this.btnFuentes_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(552, 257);
			this.Controls.Add(this.btn_Reproducir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCampania)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_EditarCampania)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAgregarBanner)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Reproducir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEditarBanner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEliminarBanner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFuentes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_EliminarCampania;
        private System.Windows.Forms.PictureBox btn_EditarCampania;
        private System.Windows.Forms.PictureBox btnAgregarBanner;
        private System.Windows.Forms.PictureBox btn_Reproducir;
		private System.Windows.Forms.PictureBox btnEliminarBanner;
		private System.Windows.Forms.PictureBox btnEditarBanner;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox btnFuentes;
	}
}