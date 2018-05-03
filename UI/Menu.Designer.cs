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
            this.btn_AgregarCampania = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Reproducir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCampania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCampania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCampania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reproducir)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btn_AgregarCampania);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 83);
            this.groupBox1.TabIndex = 3;
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
            this.btn_EliminarCampania.Click += new System.EventHandler(this.btn_EliminarCampania_Click);
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
            // btn_AgregarCampania
            // 
            this.btn_AgregarCampania.Image = global::UI.Properties.Resources.btn_Agregar;
            this.btn_AgregarCampania.Location = new System.Drawing.Point(34, 20);
            this.btn_AgregarCampania.Name = "btn_AgregarCampania";
            this.btn_AgregarCampania.Size = new System.Drawing.Size(50, 50);
            this.btn_AgregarCampania.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_AgregarCampania.TabIndex = 9;
            this.btn_AgregarCampania.TabStop = false;
            this.btn_AgregarCampania.Click += new System.EventHandler(this.btn_AgregarCampania_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(19, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banners";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(471, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(509, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 32);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCampania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reproducir)).EndInit();
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
        private System.Windows.Forms.PictureBox btn_AgregarCampania;
        private System.Windows.Forms.PictureBox btn_Reproducir;
    }
}