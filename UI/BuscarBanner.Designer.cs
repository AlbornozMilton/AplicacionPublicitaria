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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.gbx_ParamBusqueda = new System.Windows.Forms.GroupBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.dtp_FechaDesde = new System.Windows.Forms.DateTimePicker();
			this.label_Hasta = new System.Windows.Forms.Label();
			this.label_Desde = new System.Windows.Forms.Label();
			this.dtp_FechaHasta = new System.Windows.Forms.DateTimePicker();
			this.TB_Nombre = new System.Windows.Forms.TextBox();
			this.btn_Filtrar = new System.Windows.Forms.PictureBox();
			this.panelResult = new System.Windows.Forms.Panel();
			this.datagridHorario = new System.Windows.Forms.DataGridView();
			this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rangoHorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridBanner = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRangoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_Dias = new System.Windows.Forms.Label();
			this.lbl_Min = new System.Windows.Forms.Label();
			this.lbl_X = new System.Windows.Forms.Label();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.gbx_ParamBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Filtrar)).BeginInit();
			this.panelResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridHorario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rangoHorarioBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridBanner)).BeginInit();
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
			this.gbx_ParamBusqueda.TabIndex = 0;
			this.gbx_ParamBusqueda.TabStop = false;
			this.gbx_ParamBusqueda.Text = "Filtrar Banners";
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
			// dtp_FechaDesde
			// 
			this.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaDesde.Location = new System.Drawing.Point(387, 31);
			this.dtp_FechaDesde.Name = "dtp_FechaDesde";
			this.dtp_FechaDesde.Size = new System.Drawing.Size(113, 22);
			this.dtp_FechaDesde.TabIndex = 1;
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
			this.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaHasta.Location = new System.Drawing.Point(563, 31);
			this.dtp_FechaHasta.Name = "dtp_FechaHasta";
			this.dtp_FechaHasta.Size = new System.Drawing.Size(113, 22);
			this.dtp_FechaHasta.TabIndex = 2;
			// 
			// TB_Nombre
			// 
			this.TB_Nombre.Location = new System.Drawing.Point(83, 31);
			this.TB_Nombre.Multiline = true;
			this.TB_Nombre.Name = "TB_Nombre";
			this.TB_Nombre.Size = new System.Drawing.Size(243, 22);
			this.TB_Nombre.TabIndex = 0;
			// 
			// btn_Filtrar
			// 
			this.btn_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btn_Filtrar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn_Filtrar.Image = global::UI.Properties.Resources.btn_Buscar;
			this.btn_Filtrar.Location = new System.Drawing.Point(784, 18);
			this.btn_Filtrar.Name = "btn_Filtrar";
			this.btn_Filtrar.Size = new System.Drawing.Size(35, 35);
			this.btn_Filtrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btn_Filtrar.TabIndex = 26;
			this.btn_Filtrar.TabStop = false;
			this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
			this.btn_Filtrar.MouseLeave += new System.EventHandler(this.btn_Filtrar_MouseLeave);
			this.btn_Filtrar.MouseHover += new System.EventHandler(this.btn_Filtrar_MouseHover);
			// 
			// panelResult
			// 
			this.panelResult.Controls.Add(this.datagridHorario);
			this.panelResult.Location = new System.Drawing.Point(640, 189);
			this.panelResult.Name = "panelResult";
			this.panelResult.Size = new System.Drawing.Size(210, 269);
			this.panelResult.TabIndex = 29;
			// 
			// datagridHorario
			// 
			this.datagridHorario.AllowUserToAddRows = false;
			this.datagridHorario.AllowUserToDeleteRows = false;
			this.datagridHorario.AllowUserToOrderColumns = true;
			this.datagridHorario.AutoGenerateColumns = false;
			this.datagridHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.datagridHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagridHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaFinDataGridViewTextBoxColumn});
			this.datagridHorario.DataSource = this.rangoHorarioBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagridHorario.DefaultCellStyle = dataGridViewCellStyle2;
			this.datagridHorario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.datagridHorario.Location = new System.Drawing.Point(0, 0);
			this.datagridHorario.Name = "datagridHorario";
			this.datagridHorario.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.datagridHorario.RowHeadersVisible = false;
			this.datagridHorario.Size = new System.Drawing.Size(210, 269);
			this.datagridHorario.TabIndex = 0;
			// 
			// horaInicioDataGridViewTextBoxColumn
			// 
			this.horaInicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
			this.horaInicioDataGridViewTextBoxColumn.HeaderText = "Inicio";
			this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
			this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// horaFinDataGridViewTextBoxColumn
			// 
			this.horaFinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.horaFinDataGridViewTextBoxColumn.DataPropertyName = "HoraFin";
			this.horaFinDataGridViewTextBoxColumn.HeaderText = "Fin";
			this.horaFinDataGridViewTextBoxColumn.Name = "horaFinDataGridViewTextBoxColumn";
			this.horaFinDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rangoHorarioBindingSource
			// 
			this.rangoHorarioBindingSource.DataSource = typeof(Dominio.RangoHorario);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridBanner);
			this.panel1.Location = new System.Drawing.Point(16, 119);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 339);
			this.panel1.TabIndex = 30;
			// 
			// dataGridBanner
			// 
			this.dataGridBanner.AllowUserToAddRows = false;
			this.dataGridBanner.AllowUserToDeleteRows = false;
			this.dataGridBanner.AllowUserToOrderColumns = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridBanner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridBanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridBanner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colDescripcion,
            this.colRangoFecha});
			this.dataGridBanner.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridBanner.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridBanner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridBanner.Location = new System.Drawing.Point(0, 0);
			this.dataGridBanner.Name = "dataGridBanner";
			this.dataGridBanner.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridBanner.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridBanner.RowHeadersVisible = false;
			this.dataGridBanner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridBanner.Size = new System.Drawing.Size(618, 339);
			this.dataGridBanner.TabIndex = 0;
			this.dataGridBanner.SelectionChanged += new System.EventHandler(this.dataGridBanner_SelectionChanged);
			// 
			// colId
			// 
			this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colId.FillWeight = 40F;
			this.colId.HeaderText = "Id";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			// 
			// colNombre
			// 
			this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNombre.HeaderText = "Nombre";
			this.colNombre.Name = "colNombre";
			this.colNombre.ReadOnly = true;
			// 
			// colDescripcion
			// 
			this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDescripcion.HeaderText = "Descripción";
			this.colDescripcion.Name = "colDescripcion";
			this.colDescripcion.ReadOnly = true;
			// 
			// colRangoFecha
			// 
			this.colRangoFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colRangoFecha.HeaderText = "Rango Fecha";
			this.colRangoFecha.Name = "colRangoFecha";
			this.colRangoFecha.ReadOnly = true;
			// 
			// lbl_Dias
			// 
			this.lbl_Dias.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Dias.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Dias.ForeColor = System.Drawing.Color.White;
			this.lbl_Dias.Location = new System.Drawing.Point(637, 119);
			this.lbl_Dias.Name = "lbl_Dias";
			this.lbl_Dias.Size = new System.Drawing.Size(213, 67);
			this.lbl_Dias.TabIndex = 31;
			this.lbl_Dias.Text = "DIAS";
			this.lbl_Dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Min
			// 
			this.lbl_Min.AutoSize = true;
			this.lbl_Min.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Min.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_Min.Location = new System.Drawing.Point(782, -1);
			this.lbl_Min.Name = "lbl_Min";
			this.lbl_Min.Size = new System.Drawing.Size(36, 39);
			this.lbl_Min.TabIndex = 33;
			this.lbl_Min.Text = "_";
			this.lbl_Min.Click += new System.EventHandler(this.lbl_Min_Click);
			// 
			// lbl_X
			// 
			this.lbl_X.AutoSize = true;
			this.lbl_X.BackColor = System.Drawing.Color.Transparent;
			this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_X.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_X.Location = new System.Drawing.Point(820, 15);
			this.lbl_X.Name = "lbl_X";
			this.lbl_X.Size = new System.Drawing.Size(30, 29);
			this.lbl_X.TabIndex = 32;
			this.lbl_X.Text = "X";
			this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Aceptar.Location = new System.Drawing.Point(640, 464);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(81, 33);
			this.btn_Aceptar.TabIndex = 34;
			this.btn_Aceptar.Text = "Aceptar";
			this.btn_Aceptar.UseVisualStyleBackColor = true;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancelar.Location = new System.Drawing.Point(769, 464);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(81, 33);
			this.btn_Cancelar.TabIndex = 35;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = true;
			this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
			// 
			// BuscarBanner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(868, 519);
			this.Controls.Add(this.btn_Cancelar);
			this.Controls.Add(this.btn_Aceptar);
			this.Controls.Add(this.lbl_Min);
			this.Controls.Add(this.lbl_X);
			this.Controls.Add(this.lbl_Dias);
			this.Controls.Add(this.panelResult);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbx_ParamBusqueda);
			this.Controls.Add(this.lblTitulo);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BuscarBanner";
			this.Text = "BuscarBanner";
			this.Load += new System.EventHandler(this.BuscarBanner_Load);
			this.gbx_ParamBusqueda.ResumeLayout(false);
			this.gbx_ParamBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Filtrar)).EndInit();
			this.panelResult.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.datagridHorario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rangoHorarioBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridBanner)).EndInit();
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
		private System.Windows.Forms.DataGridView datagridHorario;
		private System.Windows.Forms.BindingSource rangoHorarioBindingSource;
		private System.Windows.Forms.DataGridView dataGridBanner;
		private System.Windows.Forms.Label lbl_Dias;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaFinDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label lbl_Min;
		private System.Windows.Forms.Label lbl_X;
		private System.Windows.Forms.Button btn_Aceptar;
		private System.Windows.Forms.Button btn_Cancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRangoFecha;
	}
}