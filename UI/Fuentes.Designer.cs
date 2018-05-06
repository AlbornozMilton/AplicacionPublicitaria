namespace UI
{
	partial class Fuentes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.lblFuente = new System.Windows.Forms.Label();
			this.lbl_tipoFuente = new System.Windows.Forms.Label();
			this.btnNuevaFuente = new System.Windows.Forms.PictureBox();
			this.groupBox_items = new System.Windows.Forms.GroupBox();
			this.dGV_itemsFuente = new System.Windows.Forms.DataGridView();
			this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbxTipoFuente = new System.Windows.Forms.TextBox();
			this.lbl_modItem = new System.Windows.Forms.Label();
			this.ModificarItem = new System.Windows.Forms.Button();
			this.lbl_eliminarItem = new System.Windows.Forms.Label();
			this.btn_eliminarItem = new System.Windows.Forms.PictureBox();
			this.lblNuevoItem = new System.Windows.Forms.Label();
			this.btnAgregarItem = new System.Windows.Forms.PictureBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lbl_nuevaFuente = new System.Windows.Forms.Label();
			this.lblTodosItems = new System.Windows.Forms.Label();
			this.btnTodosItems = new System.Windows.Forms.PictureBox();
			this.cbx_Fuente = new System.Windows.Forms.ComboBox();
			this.lblModificarFuente = new System.Windows.Forms.Label();
			this.btnModFuente = new System.Windows.Forms.Button();
			this.lblElimFuente = new System.Windows.Forms.Label();
			this.btnEliminarFuente = new System.Windows.Forms.PictureBox();
			this.lblX = new System.Windows.Forms.Label();
			this.lbl_ = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.btnNuevaFuente)).BeginInit();
			this.groupBox_items.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_itemsFuente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_eliminarItem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAgregarItem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTodosItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEliminarFuente)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.White;
			this.lbl_Title.Location = new System.Drawing.Point(13, 12);
			this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(78, 18);
			this.lbl_Title.TabIndex = 4;
			this.lbl_Title.Text = "Fuentes";
			// 
			// lblFuente
			// 
			this.lblFuente.AutoSize = true;
			this.lblFuente.BackColor = System.Drawing.Color.Transparent;
			this.lblFuente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFuente.ForeColor = System.Drawing.Color.White;
			this.lblFuente.Location = new System.Drawing.Point(53, 46);
			this.lblFuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFuente.Name = "lblFuente";
			this.lblFuente.Size = new System.Drawing.Size(59, 18);
			this.lblFuente.TabIndex = 38;
			this.lblFuente.Text = "Fuente";
			// 
			// lbl_tipoFuente
			// 
			this.lbl_tipoFuente.AutoSize = true;
			this.lbl_tipoFuente.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tipoFuente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tipoFuente.ForeColor = System.Drawing.Color.White;
			this.lbl_tipoFuente.Location = new System.Drawing.Point(16, 85);
			this.lbl_tipoFuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_tipoFuente.Name = "lbl_tipoFuente";
			this.lbl_tipoFuente.Size = new System.Drawing.Size(96, 18);
			this.lbl_tipoFuente.TabIndex = 36;
			this.lbl_tipoFuente.Text = "Tipo Fuente";
			// 
			// btnNuevaFuente
			// 
			this.btnNuevaFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevaFuente.Image = global::UI.Properties.Resources.btn_Agregar;
			this.btnNuevaFuente.Location = new System.Drawing.Point(591, 96);
			this.btnNuevaFuente.Name = "btnNuevaFuente";
			this.btnNuevaFuente.Size = new System.Drawing.Size(35, 35);
			this.btnNuevaFuente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnNuevaFuente.TabIndex = 37;
			this.btnNuevaFuente.TabStop = false;
			this.btnNuevaFuente.Click += new System.EventHandler(this.btnNuevaFuente_Click);
			// 
			// groupBox_items
			// 
			this.groupBox_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_items.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_items.BackColor = System.Drawing.Color.Maroon;
			this.groupBox_items.Controls.Add(this.dGV_itemsFuente);
			this.groupBox_items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox_items.Location = new System.Drawing.Point(16, 148);
			this.groupBox_items.Name = "groupBox_items";
			this.groupBox_items.Size = new System.Drawing.Size(808, 229);
			this.groupBox_items.TabIndex = 39;
			this.groupBox_items.TabStop = false;
			this.groupBox_items.Text = "Últimos Items";
			// 
			// dGV_itemsFuente
			// 
			this.dGV_itemsFuente.AutoGenerateColumns = false;
			this.dGV_itemsFuente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_itemsFuente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.textoDataGridViewTextBoxColumn});
			this.dGV_itemsFuente.DataSource = this.iItemBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dGV_itemsFuente.DefaultCellStyle = dataGridViewCellStyle2;
			this.dGV_itemsFuente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dGV_itemsFuente.Location = new System.Drawing.Point(3, 16);
			this.dGV_itemsFuente.MultiSelect = false;
			this.dGV_itemsFuente.Name = "dGV_itemsFuente";
			this.dGV_itemsFuente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dGV_itemsFuente.RowHeadersVisible = false;
			this.dGV_itemsFuente.Size = new System.Drawing.Size(802, 210);
			this.dGV_itemsFuente.TabIndex = 0;
			// 
			// tituloDataGridViewTextBoxColumn
			// 
			this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
			this.tituloDataGridViewTextBoxColumn.FillWeight = 60F;
			this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
			this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
			// 
			// fechaDataGridViewTextBoxColumn
			// 
			this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
			this.fechaDataGridViewTextBoxColumn.FillWeight = 40F;
			this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
			this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
			// 
			// textoDataGridViewTextBoxColumn
			// 
			this.textoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.textoDataGridViewTextBoxColumn.DataPropertyName = "Texto";
			this.textoDataGridViewTextBoxColumn.HeaderText = "Texto";
			this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
			// 
			// iItemBindingSource
			// 
			this.iItemBindingSource.DataSource = typeof(Dominio.IItem);
			// 
			// tbxTipoFuente
			// 
			this.tbxTipoFuente.Location = new System.Drawing.Point(119, 86);
			this.tbxTipoFuente.Name = "tbxTipoFuente";
			this.tbxTipoFuente.ReadOnly = true;
			this.tbxTipoFuente.Size = new System.Drawing.Size(120, 20);
			this.tbxTipoFuente.TabIndex = 41;
			// 
			// lbl_modItem
			// 
			this.lbl_modItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_modItem.AutoSize = true;
			this.lbl_modItem.BackColor = System.Drawing.Color.Maroon;
			this.lbl_modItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_modItem.Location = new System.Drawing.Point(102, 421);
			this.lbl_modItem.Name = "lbl_modItem";
			this.lbl_modItem.Size = new System.Drawing.Size(73, 13);
			this.lbl_modItem.TabIndex = 48;
			this.lbl_modItem.Text = "Modificar Item";
			this.lbl_modItem.Visible = false;
			// 
			// ModificarItem
			// 
			this.ModificarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ModificarItem.Image = global::UI.Properties.Resources.btn_Editar;
			this.ModificarItem.Location = new System.Drawing.Point(121, 383);
			this.ModificarItem.Name = "ModificarItem";
			this.ModificarItem.Size = new System.Drawing.Size(35, 35);
			this.ModificarItem.TabIndex = 47;
			this.ModificarItem.UseVisualStyleBackColor = true;
			this.ModificarItem.Click += new System.EventHandler(this.ModificarItem_Click);
			// 
			// lbl_eliminarItem
			// 
			this.lbl_eliminarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_eliminarItem.AutoSize = true;
			this.lbl_eliminarItem.BackColor = System.Drawing.Color.Maroon;
			this.lbl_eliminarItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_eliminarItem.Location = new System.Drawing.Point(192, 421);
			this.lbl_eliminarItem.Name = "lbl_eliminarItem";
			this.lbl_eliminarItem.Size = new System.Drawing.Size(66, 13);
			this.lbl_eliminarItem.TabIndex = 46;
			this.lbl_eliminarItem.Text = "Eliminar Item";
			this.lbl_eliminarItem.Visible = false;
			// 
			// btn_eliminarItem
			// 
			this.btn_eliminarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_eliminarItem.Image = global::UI.Properties.Resources.btn_Cerrar;
			this.btn_eliminarItem.Location = new System.Drawing.Point(207, 383);
			this.btn_eliminarItem.Name = "btn_eliminarItem";
			this.btn_eliminarItem.Size = new System.Drawing.Size(35, 35);
			this.btn_eliminarItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btn_eliminarItem.TabIndex = 45;
			this.btn_eliminarItem.TabStop = false;
			this.btn_eliminarItem.Click += new System.EventHandler(this.btn_eliminarItem_Click);
			// 
			// lblNuevoItem
			// 
			this.lblNuevoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNuevoItem.AutoSize = true;
			this.lblNuevoItem.BackColor = System.Drawing.Color.Maroon;
			this.lblNuevoItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNuevoItem.Location = new System.Drawing.Point(16, 422);
			this.lblNuevoItem.Name = "lblNuevoItem";
			this.lblNuevoItem.Size = new System.Drawing.Size(62, 13);
			this.lblNuevoItem.TabIndex = 43;
			this.lblNuevoItem.Text = "Nuevo Item";
			this.lblNuevoItem.Visible = false;
			// 
			// btnAgregarItem
			// 
			this.btnAgregarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgregarItem.Image = global::UI.Properties.Resources.btn_Agregar;
			this.btnAgregarItem.Location = new System.Drawing.Point(29, 383);
			this.btnAgregarItem.Name = "btnAgregarItem";
			this.btnAgregarItem.Size = new System.Drawing.Size(35, 35);
			this.btnAgregarItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnAgregarItem.TabIndex = 44;
			this.btnAgregarItem.TabStop = false;
			this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(740, 401);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 33);
			this.btnAceptar.TabIndex = 49;
			this.btnAceptar.Text = "Hecho";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lbl_nuevaFuente
			// 
			this.lbl_nuevaFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_nuevaFuente.AutoSize = true;
			this.lbl_nuevaFuente.BackColor = System.Drawing.Color.Maroon;
			this.lbl_nuevaFuente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_nuevaFuente.Location = new System.Drawing.Point(569, 134);
			this.lbl_nuevaFuente.Name = "lbl_nuevaFuente";
			this.lbl_nuevaFuente.Size = new System.Drawing.Size(75, 13);
			this.lbl_nuevaFuente.TabIndex = 42;
			this.lbl_nuevaFuente.Text = "Nueva Fuente";
			this.lbl_nuevaFuente.Visible = false;
			// 
			// lblTodosItems
			// 
			this.lblTodosItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTodosItems.AutoSize = true;
			this.lblTodosItems.BackColor = System.Drawing.Color.Maroon;
			this.lblTodosItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTodosItems.Location = new System.Drawing.Point(283, 422);
			this.lblTodosItems.Name = "lblTodosItems";
			this.lblTodosItems.Size = new System.Drawing.Size(75, 13);
			this.lblTodosItems.TabIndex = 51;
			this.lblTodosItems.Text = "Mostrar Todos";
			this.lblTodosItems.Visible = false;
			// 
			// btnTodosItems
			// 
			this.btnTodosItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTodosItems.Image = global::UI.Properties.Resources.btn_Cerrar;
			this.btnTodosItems.Location = new System.Drawing.Point(306, 383);
			this.btnTodosItems.Name = "btnTodosItems";
			this.btnTodosItems.Size = new System.Drawing.Size(35, 35);
			this.btnTodosItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnTodosItems.TabIndex = 50;
			this.btnTodosItems.TabStop = false;
			this.btnTodosItems.Click += new System.EventHandler(this.btnTodosItems_Click);
			// 
			// cbx_Fuente
			// 
			this.cbx_Fuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Fuente.FormattingEnabled = true;
			this.cbx_Fuente.Location = new System.Drawing.Point(119, 46);
			this.cbx_Fuente.Name = "cbx_Fuente";
			this.cbx_Fuente.Size = new System.Drawing.Size(466, 21);
			this.cbx_Fuente.TabIndex = 52;
			this.cbx_Fuente.SelectedIndexChanged += new System.EventHandler(this.cbx_Fuente_SelectedIndexChanged);
			// 
			// lblModificarFuente
			// 
			this.lblModificarFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblModificarFuente.AutoSize = true;
			this.lblModificarFuente.BackColor = System.Drawing.Color.Maroon;
			this.lblModificarFuente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblModificarFuente.Location = new System.Drawing.Point(650, 134);
			this.lblModificarFuente.Name = "lblModificarFuente";
			this.lblModificarFuente.Size = new System.Drawing.Size(86, 13);
			this.lblModificarFuente.TabIndex = 56;
			this.lblModificarFuente.Text = "Modificar Fuente";
			this.lblModificarFuente.Visible = false;
			// 
			// btnModFuente
			// 
			this.btnModFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModFuente.Image = global::UI.Properties.Resources.btn_Editar;
			this.btnModFuente.Location = new System.Drawing.Point(677, 96);
			this.btnModFuente.Name = "btnModFuente";
			this.btnModFuente.Size = new System.Drawing.Size(35, 35);
			this.btnModFuente.TabIndex = 55;
			this.btnModFuente.UseVisualStyleBackColor = true;
			this.btnModFuente.Click += new System.EventHandler(this.btnModFuente_Click);
			// 
			// lblElimFuente
			// 
			this.lblElimFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblElimFuente.AutoSize = true;
			this.lblElimFuente.BackColor = System.Drawing.Color.Maroon;
			this.lblElimFuente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblElimFuente.Location = new System.Drawing.Point(742, 134);
			this.lblElimFuente.Name = "lblElimFuente";
			this.lblElimFuente.Size = new System.Drawing.Size(79, 13);
			this.lblElimFuente.TabIndex = 54;
			this.lblElimFuente.Text = "Eliminar Fuente";
			this.lblElimFuente.Visible = false;
			// 
			// btnEliminarFuente
			// 
			this.btnEliminarFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminarFuente.Image = global::UI.Properties.Resources.btn_Cerrar;
			this.btnEliminarFuente.Location = new System.Drawing.Point(763, 96);
			this.btnEliminarFuente.Name = "btnEliminarFuente";
			this.btnEliminarFuente.Size = new System.Drawing.Size(35, 35);
			this.btnEliminarFuente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnEliminarFuente.TabIndex = 53;
			this.btnEliminarFuente.TabStop = false;
			this.btnEliminarFuente.Click += new System.EventHandler(this.btnEliminarFuente_Click);
			// 
			// lblX
			// 
			this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblX.AutoSize = true;
			this.lblX.BackColor = System.Drawing.Color.Transparent;
			this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX.ForeColor = System.Drawing.Color.Transparent;
			this.lblX.Location = new System.Drawing.Point(794, 14);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(30, 29);
			this.lblX.TabIndex = 58;
			this.lblX.Text = "X";
			this.lblX.Click += new System.EventHandler(this.lblX_Click);
			// 
			// lbl_
			// 
			this.lbl_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_.AutoSize = true;
			this.lbl_.BackColor = System.Drawing.Color.Transparent;
			this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_.ForeColor = System.Drawing.Color.Transparent;
			this.lbl_.Location = new System.Drawing.Point(756, -2);
			this.lbl_.Name = "lbl_";
			this.lbl_.Size = new System.Drawing.Size(36, 39);
			this.lbl_.TabIndex = 57;
			this.lbl_.Text = "_";
			this.lbl_.Click += new System.EventHandler(this.lbl__Click);
			// 
			// Fuentes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(836, 454);
			this.Controls.Add(this.lblX);
			this.Controls.Add(this.lbl_);
			this.Controls.Add(this.lblModificarFuente);
			this.Controls.Add(this.btnModFuente);
			this.Controls.Add(this.lblElimFuente);
			this.Controls.Add(this.btnEliminarFuente);
			this.Controls.Add(this.cbx_Fuente);
			this.Controls.Add(this.lblTodosItems);
			this.Controls.Add(this.btnTodosItems);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lbl_modItem);
			this.Controls.Add(this.ModificarItem);
			this.Controls.Add(this.lbl_eliminarItem);
			this.Controls.Add(this.btn_eliminarItem);
			this.Controls.Add(this.lblNuevoItem);
			this.Controls.Add(this.btnAgregarItem);
			this.Controls.Add(this.lbl_nuevaFuente);
			this.Controls.Add(this.tbxTipoFuente);
			this.Controls.Add(this.groupBox_items);
			this.Controls.Add(this.lblFuente);
			this.Controls.Add(this.btnNuevaFuente);
			this.Controls.Add(this.lbl_tipoFuente);
			this.Controls.Add(this.lbl_Title);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(669, 454);
			this.Name = "Fuentes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fuentes";
			this.Load += new System.EventHandler(this.Fuentes_Load);
			((System.ComponentModel.ISupportInitialize)(this.btnNuevaFuente)).EndInit();
			this.groupBox_items.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dGV_itemsFuente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_eliminarItem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAgregarItem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTodosItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnEliminarFuente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Label lblFuente;
		private System.Windows.Forms.Label lbl_tipoFuente;
		private System.Windows.Forms.PictureBox btnNuevaFuente;
		private System.Windows.Forms.GroupBox groupBox_items;
		private System.Windows.Forms.DataGridView dGV_itemsFuente;
		private System.Windows.Forms.TextBox tbxTipoFuente;
		private System.Windows.Forms.Label lbl_modItem;
		private System.Windows.Forms.Button ModificarItem;
		private System.Windows.Forms.Label lbl_eliminarItem;
		private System.Windows.Forms.PictureBox btn_eliminarItem;
		private System.Windows.Forms.Label lblNuevoItem;
		private System.Windows.Forms.PictureBox btnAgregarItem;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lbl_nuevaFuente;
		private System.Windows.Forms.Label lblTodosItems;
		private System.Windows.Forms.PictureBox btnTodosItems;
		private System.Windows.Forms.ComboBox cbx_Fuente;
		private System.Windows.Forms.Label lblModificarFuente;
		private System.Windows.Forms.Button btnModFuente;
		private System.Windows.Forms.Label lblElimFuente;
		private System.Windows.Forms.PictureBox btnEliminarFuente;
		private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource iItemBindingSource;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.Label lbl_;
	}
}