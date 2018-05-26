namespace UI
{
	partial class BuscarBanner
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.gbx_ParamBusqueda = new System.Windows.Forms.GroupBox();
			this.dtp_FechaDesde = new System.Windows.Forms.DateTimePicker();
			this.label_Hasta = new System.Windows.Forms.Label();
			this.label_Desde = new System.Windows.Forms.Label();
			this.dtp_FechaHasta = new System.Windows.Forms.DateTimePicker();
			this.TB_Nombre = new System.Windows.Forms.TextBox();
			this.btn_Filtrar = new System.Windows.Forms.PictureBox();
			this.panelResult = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lbl_Dias = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gbx_ParamBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Filtrar)).BeginInit();
			this.panelResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(13, 15);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(137, 18);
			this.lblTitulo.TabIndex = 4;
			this.lblTitulo.Text = "Buscar Banner";
			// 
			// gbx_ParamBusqueda
			// 
			this.gbx_ParamBusqueda.Controls.Add(this.lblNombre);
			this.gbx_ParamBusqueda.Controls.Add(this.dtp_FechaDesde);
			this.gbx_ParamBusqueda.Controls.Add(this.label_Hasta);
			this.gbx_ParamBusqueda.Controls.Add(this.label_Desde);
			this.gbx_ParamBusqueda.Controls.Add(this.dtp_FechaHasta);
			this.gbx_ParamBusqueda.Controls.Add(this.TB_Nombre);
			this.gbx_ParamBusqueda.Controls.Add(this.btn_Filtrar);
			this.gbx_ParamBusqueda.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbx_ParamBusqueda.ForeColor = System.Drawing.Color.White;
			this.gbx_ParamBusqueda.Location = new System.Drawing.Point(16, 46);
			this.gbx_ParamBusqueda.Name = "gbx_ParamBusqueda";
			this.gbx_ParamBusqueda.Size = new System.Drawing.Size(834, 67);
			this.gbx_ParamBusqueda.TabIndex = 28;
			this.gbx_ParamBusqueda.TabStop = false;
			this.gbx_ParamBusqueda.Text = "Filtrar Banners";
			// 
			// dtp_FechaDesde
			// 
			this.dtp_FechaDesde.Enabled = false;
			this.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaDesde.Location = new System.Drawing.Point(387, 31);
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
			this.label_Hasta.Location = new System.Drawing.Point(507, 34);
			this.label_Hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Hasta.Name = "label_Hasta";
			this.label_Hasta.Size = new System.Drawing.Size(49, 14);
			this.label_Hasta.TabIndex = 41;
			this.label_Hasta.Text = "Hasta:";
			// 
			// label_Desde
			// 
			this.label_Desde.AutoSize = true;
			this.label_Desde.BackColor = System.Drawing.Color.Transparent;
			this.label_Desde.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Desde.ForeColor = System.Drawing.Color.White;
			this.label_Desde.Location = new System.Drawing.Point(333, 34);
			this.label_Desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Desde.Name = "label_Desde";
			this.label_Desde.Size = new System.Drawing.Size(52, 14);
			this.label_Desde.TabIndex = 40;
			this.label_Desde.Text = "Desde:";
			// 
			// dtp_FechaHasta
			// 
			this.dtp_FechaHasta.Enabled = false;
			this.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaHasta.Location = new System.Drawing.Point(563, 31);
			this.dtp_FechaHasta.Name = "dtp_FechaHasta";
			this.dtp_FechaHasta.Size = new System.Drawing.Size(113, 22);
			this.dtp_FechaHasta.TabIndex = 35;
			// 
			// TB_Nombre
			// 
			this.TB_Nombre.Enabled = false;
			this.TB_Nombre.Location = new System.Drawing.Point(83, 31);
			this.TB_Nombre.Name = "TB_Nombre";
			this.TB_Nombre.Size = new System.Drawing.Size(243, 22);
			this.TB_Nombre.TabIndex = 28;
			// 
			// btn_Filtrar
			// 
			this.btn_Filtrar.Image = global::UI.Properties.Resources.btn_Buscar;
			this.btn_Filtrar.Location = new System.Drawing.Point(784, 18);
			this.btn_Filtrar.Name = "btn_Filtrar";
			this.btn_Filtrar.Size = new System.Drawing.Size(35, 35);
			this.btn_Filtrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btn_Filtrar.TabIndex = 26;
			this.btn_Filtrar.TabStop = false;
			// 
			// panelResult
			// 
			this.panelResult.Controls.Add(this.dataGridView1);
			this.panelResult.Location = new System.Drawing.Point(640, 189);
			this.panelResult.Name = "panelResult";
			this.panelResult.Size = new System.Drawing.Size(210, 269);
			this.panelResult.TabIndex = 29;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(16, 119);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 339);
			this.panel1.TabIndex = 30;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(16, 34);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(61, 14);
			this.lblNombre.TabIndex = 43;
			this.lblNombre.Text = "Nombre:";
			// 
			// lbl_Dias
			// 
			this.lbl_Dias.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Dias.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Dias.ForeColor = System.Drawing.Color.White;
			this.lbl_Dias.Location = new System.Drawing.Point(637, 119);
			this.lbl_Dias.Name = "lbl_Dias";
			this.lbl_Dias.Size = new System.Drawing.Size(213, 67);
			this.lbl_Dias.TabIndex = 31;
			this.lbl_Dias.Text = "Dias";
			this.lbl_Dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(210, 269);
			this.dataGridView1.TabIndex = 0;
			// 
			// BuscarBanner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(874, 483);
			this.Controls.Add(this.lbl_Dias);
			this.Controls.Add(this.panelResult);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbx_ParamBusqueda);
			this.Controls.Add(this.lblTitulo);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BuscarBanner";
			this.Text = "BuscarBanner";
			this.gbx_ParamBusqueda.ResumeLayout(false);
			this.gbx_ParamBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Filtrar)).EndInit();
			this.panelResult.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox gbx_ParamBusqueda;
		private System.Windows.Forms.DateTimePicker dtp_FechaDesde;
		private System.Windows.Forms.Label label_Hasta;
		private System.Windows.Forms.Label label_Desde;
		private System.Windows.Forms.DateTimePicker dtp_FechaHasta;
		private System.Windows.Forms.TextBox TB_Nombre;
		private System.Windows.Forms.PictureBox btn_Filtrar;
		private System.Windows.Forms.Panel panelResult;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lbl_Dias;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}