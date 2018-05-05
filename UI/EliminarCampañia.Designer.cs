namespace UI
{
    partial class EliminarCampañia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_Campanias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gB_Filtrar = new System.Windows.Forms.GroupBox();
            this.dtp_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label_Hasta = new System.Windows.Forms.Label();
            this.label_Desde = new System.Windows.Forms.Label();
            this.dtp_FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.RangoFecha = new System.Windows.Forms.CheckBox();
            this.Nombre = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Filtrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Campanias)).BeginInit();
            this.gB_Filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Filtrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Campanias
            // 
            this.dGV_Campanias.AllowUserToAddRows = false;
            this.dGV_Campanias.AllowUserToDeleteRows = false;
            this.dGV_Campanias.AllowUserToResizeColumns = false;
            this.dGV_Campanias.AllowUserToResizeRows = false;
            this.dGV_Campanias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Campanias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Campanias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGV_Campanias.Location = new System.Drawing.Point(372, 45);
            this.dGV_Campanias.Name = "dGV_Campanias";
            this.dGV_Campanias.ReadOnly = true;
            this.dGV_Campanias.RowHeadersVisible = false;
            this.dGV_Campanias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Campanias.Size = new System.Drawing.Size(482, 143);
            this.dGV_Campanias.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nombre";
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Dominio.RangoFecha.FechaInicio";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Fecha Inicio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FechaFin";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Fecha Fin";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eliminar Campaña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(829, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(791, -6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 48);
            this.label8.TabIndex = 24;
            this.label8.Text = "_";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(670, 312);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(81, 33);
            this.btn_Aceptar.TabIndex = 25;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(773, 312);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(81, 33);
            this.btn_Cancelar.TabIndex = 26;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // gB_Filtrar
            // 
            this.gB_Filtrar.Controls.Add(this.dtp_FechaDesde);
            this.gB_Filtrar.Controls.Add(this.label_Hasta);
            this.gB_Filtrar.Controls.Add(this.label_Desde);
            this.gB_Filtrar.Controls.Add(this.dtp_FechaHasta);
            this.gB_Filtrar.Controls.Add(this.RangoFecha);
            this.gB_Filtrar.Controls.Add(this.Nombre);
            this.gB_Filtrar.Controls.Add(this.textBox1);
            this.gB_Filtrar.Controls.Add(this.btn_Filtrar);
            this.gB_Filtrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_Filtrar.ForeColor = System.Drawing.Color.White;
            this.gB_Filtrar.Location = new System.Drawing.Point(19, 45);
            this.gB_Filtrar.Name = "gB_Filtrar";
            this.gB_Filtrar.Size = new System.Drawing.Size(334, 300);
            this.gB_Filtrar.TabIndex = 27;
            this.gB_Filtrar.TabStop = false;
            this.gB_Filtrar.Text = "Filtrar Campañas";
            // 
            // dtp_FechaDesde
            // 
            this.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaDesde.Location = new System.Drawing.Point(106, 138);
            this.dtp_FechaDesde.Name = "dtp_FechaDesde";
            this.dtp_FechaDesde.Size = new System.Drawing.Size(113, 22);
            this.dtp_FechaDesde.TabIndex = 42;
            // 
            // label_Hasta
            // 
            this.label_Hasta.AutoSize = true;
            this.label_Hasta.BackColor = System.Drawing.Color.Transparent;
            this.label_Hasta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hasta.ForeColor = System.Drawing.Color.White;
            this.label_Hasta.Location = new System.Drawing.Point(40, 186);
            this.label_Hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Hasta.Name = "label_Hasta";
            this.label_Hasta.Size = new System.Drawing.Size(44, 14);
            this.label_Hasta.TabIndex = 41;
            this.label_Hasta.Text = "Hasta";
            // 
            // label_Desde
            // 
            this.label_Desde.AutoSize = true;
            this.label_Desde.BackColor = System.Drawing.Color.Transparent;
            this.label_Desde.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desde.ForeColor = System.Drawing.Color.White;
            this.label_Desde.Location = new System.Drawing.Point(40, 144);
            this.label_Desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Desde.Name = "label_Desde";
            this.label_Desde.Size = new System.Drawing.Size(47, 14);
            this.label_Desde.TabIndex = 40;
            this.label_Desde.Text = "Desde";
            // 
            // dtp_FechaHasta
            // 
            this.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaHasta.Location = new System.Drawing.Point(106, 180);
            this.dtp_FechaHasta.Name = "dtp_FechaHasta";
            this.dtp_FechaHasta.Size = new System.Drawing.Size(113, 22);
            this.dtp_FechaHasta.TabIndex = 35;
            // 
            // RangoFecha
            // 
            this.RangoFecha.AutoSize = true;
            this.RangoFecha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangoFecha.Location = new System.Drawing.Point(14, 90);
            this.RangoFecha.Name = "RangoFecha";
            this.RangoFecha.Size = new System.Drawing.Size(122, 22);
            this.RangoFecha.TabIndex = 31;
            this.RangoFecha.Text = "Rango Fecha";
            this.RangoFecha.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(14, 39);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(86, 22);
            this.Nombre.TabIndex = 30;
            this.Nombre.Text = "Nombre";
            this.Nombre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 28;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Image = global::UI.Properties.Resources.btn_Buscar;
            this.btn_Filtrar.Location = new System.Drawing.Point(265, 235);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(35, 35);
            this.btn_Filtrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Filtrar.TabIndex = 26;
            this.btn_Filtrar.TabStop = false;
            // 
            // EliminarCampañia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 364);
            this.Controls.Add(this.gB_Filtrar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Campanias);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCampañia";
            this.Text = "EliminarCampañia";
            this.Load += new System.EventHandler(this.EliminarCampañia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Campanias)).EndInit();
            this.gB_Filtrar.ResumeLayout(false);
            this.gB_Filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Filtrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Campanias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox gB_Filtrar;
        private System.Windows.Forms.CheckBox RangoFecha;
        private System.Windows.Forms.CheckBox Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btn_Filtrar;
        private System.Windows.Forms.DateTimePicker dtp_FechaHasta;
        private System.Windows.Forms.Label label_Hasta;
        private System.Windows.Forms.Label label_Desde;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}