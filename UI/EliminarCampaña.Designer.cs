namespace UI
{
    partial class EliminarCampaña
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_FechaHasta = new System.Windows.Forms.TextBox();
            this.tbx_FechaDesde = new System.Windows.Forms.TextBox();
            this.dGV_Horarios = new System.Windows.Forms.DataGridView();
            this.clm_HoraDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_HoraHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.CheckBox();
            this.Friday = new System.Windows.Forms.CheckBox();
            this.Saturday = new System.Windows.Forms.CheckBox();
            this.Sunday = new System.Windows.Forms.CheckBox();
            this.Thursday = new System.Windows.Forms.CheckBox();
            this.Tuesday = new System.Windows.Forms.CheckBox();
            this.Monday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGV_Imagenes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pB_VistaPrevia = new System.Windows.Forms.PictureBox();
            this.tbx_IntTiempo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbx_Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clm_NombreImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Horarios)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Imagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_VistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(802, -7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 48);
            this.label8.TabIndex = 25;
            this.label8.Text = "_";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(835, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 32);
            this.label9.TabIndex = 26;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Eliminar Campaña";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(661, 346);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(81, 33);
            this.btn_Aceptar.TabIndex = 28;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(770, 346);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(81, 33);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre";
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Nombre.Location = new System.Drawing.Point(102, 63);
            this.tbx_Nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(332, 22);
            this.tbx_Nombre.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_FechaHasta);
            this.groupBox1.Controls.Add(this.tbx_FechaDesde);
            this.groupBox1.Controls.Add(this.dGV_Horarios);
            this.groupBox1.Controls.Add(this.Wednesday);
            this.groupBox1.Controls.Add(this.Friday);
            this.groupBox1.Controls.Add(this.Saturday);
            this.groupBox1.Controls.Add(this.Sunday);
            this.groupBox1.Controls.Add(this.Thursday);
            this.groupBox1.Controls.Add(this.Tuesday);
            this.groupBox1.Controls.Add(this.Monday);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(438, 216);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duración de la campaña";
            // 
            // tbx_FechaHasta
            // 
            this.tbx_FechaHasta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_FechaHasta.Location = new System.Drawing.Point(87, 70);
            this.tbx_FechaHasta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_FechaHasta.Name = "tbx_FechaHasta";
            this.tbx_FechaHasta.Size = new System.Drawing.Size(116, 22);
            this.tbx_FechaHasta.TabIndex = 39;
            // 
            // tbx_FechaDesde
            // 
            this.tbx_FechaDesde.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_FechaDesde.Location = new System.Drawing.Point(87, 30);
            this.tbx_FechaDesde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_FechaDesde.Name = "tbx_FechaDesde";
            this.tbx_FechaDesde.Size = new System.Drawing.Size(116, 22);
            this.tbx_FechaDesde.TabIndex = 38;
            // 
            // dGV_Horarios
            // 
            this.dGV_Horarios.AllowUserToAddRows = false;
            this.dGV_Horarios.AllowUserToDeleteRows = false;
            this.dGV_Horarios.AllowUserToOrderColumns = true;
            this.dGV_Horarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Horarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_HoraDesde,
            this.clm_HoraHasta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Horarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Horarios.Location = new System.Drawing.Point(217, 26);
            this.dGV_Horarios.Name = "dGV_Horarios";
            this.dGV_Horarios.ReadOnly = true;
            this.dGV_Horarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dGV_Horarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Horarios.Size = new System.Drawing.Size(215, 178);
            this.dGV_Horarios.TabIndex = 37;
            // 
            // clm_HoraDesde
            // 
            this.clm_HoraDesde.HeaderText = "Hora Desde";
            this.clm_HoraDesde.Name = "clm_HoraDesde";
            this.clm_HoraDesde.ReadOnly = true;
            // 
            // clm_HoraHasta
            // 
            this.clm_HoraHasta.HeaderText = "Hora Hasta";
            this.clm_HoraHasta.Name = "clm_HoraHasta";
            this.clm_HoraHasta.ReadOnly = true;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Enabled = false;
            this.Wednesday.ForeColor = System.Drawing.Color.White;
            this.Wednesday.Location = new System.Drawing.Point(65, 161);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(71, 17);
            this.Wednesday.TabIndex = 17;
            this.Wednesday.Text = "Miércoles";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Enabled = false;
            this.Friday.ForeColor = System.Drawing.Color.White;
            this.Friday.Location = new System.Drawing.Point(149, 113);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(61, 17);
            this.Friday.TabIndex = 16;
            this.Friday.Text = "Viernes";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Enabled = false;
            this.Saturday.ForeColor = System.Drawing.Color.White;
            this.Saturday.Location = new System.Drawing.Point(149, 137);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(63, 17);
            this.Saturday.TabIndex = 15;
            this.Saturday.Text = "Sábado";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Enabled = false;
            this.Sunday.ForeColor = System.Drawing.Color.White;
            this.Sunday.Location = new System.Drawing.Point(149, 161);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(68, 17);
            this.Sunday.TabIndex = 14;
            this.Sunday.Text = "Domingo";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Enabled = false;
            this.Thursday.ForeColor = System.Drawing.Color.White;
            this.Thursday.Location = new System.Drawing.Point(65, 185);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(60, 17);
            this.Thursday.TabIndex = 13;
            this.Thursday.Text = "Jueves";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Enabled = false;
            this.Tuesday.ForeColor = System.Drawing.Color.White;
            this.Tuesday.Location = new System.Drawing.Point(65, 137);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(58, 17);
            this.Tuesday.TabIndex = 11;
            this.Tuesday.Text = "Martes";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Enabled = false;
            this.Monday.ForeColor = System.Drawing.Color.White;
            this.Monday.Location = new System.Drawing.Point(65, 113);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(55, 17);
            this.Monday.TabIndex = 12;
            this.Monday.Text = "Lunes";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Días";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hasta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGV_Imagenes);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.pB_VistaPrevia);
            this.groupBox3.Controls.Add(this.tbx_IntTiempo);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(472, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 216);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imágenes";
            // 
            // dGV_Imagenes
            // 
            this.dGV_Imagenes.AllowUserToAddRows = false;
            this.dGV_Imagenes.AllowUserToDeleteRows = false;
            this.dGV_Imagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Imagenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Imagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Imagenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_NombreImagen,
            this.clm_Ruta});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Imagenes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_Imagenes.Location = new System.Drawing.Point(7, 62);
            this.dGV_Imagenes.Name = "dGV_Imagenes";
            this.dGV_Imagenes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Imagenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_Imagenes.RowHeadersVisible = false;
            this.dGV_Imagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Imagenes.Size = new System.Drawing.Size(233, 138);
            this.dGV_Imagenes.TabIndex = 35;
            this.dGV_Imagenes.SelectionChanged += new System.EventHandler(this.dGV_Imagenes_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Vista Previa";
            // 
            // pB_VistaPrevia
            // 
            this.pB_VistaPrevia.BackColor = System.Drawing.Color.White;
            this.pB_VistaPrevia.Location = new System.Drawing.Point(246, 77);
            this.pB_VistaPrevia.Name = "pB_VistaPrevia";
            this.pB_VistaPrevia.Size = new System.Drawing.Size(127, 85);
            this.pB_VistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_VistaPrevia.TabIndex = 33;
            this.pB_VistaPrevia.TabStop = false;
            // 
            // tbx_IntTiempo
            // 
            this.tbx_IntTiempo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_IntTiempo.Location = new System.Drawing.Point(229, 23);
            this.tbx_IntTiempo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_IntTiempo.Name = "tbx_IntTiempo";
            this.tbx_IntTiempo.Size = new System.Drawing.Size(34, 22);
            this.tbx_IntTiempo.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(7, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 22);
            this.label14.TabIndex = 23;
            this.label14.Text = "Intervalo entre Imagenes";
            // 
            // tbx_Codigo
            // 
            this.tbx_Codigo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Codigo.Location = new System.Drawing.Point(543, 62);
            this.tbx_Codigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_Codigo.Name = "tbx_Codigo";
            this.tbx_Codigo.Size = new System.Drawing.Size(133, 22);
            this.tbx_Codigo.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(477, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Código";
            // 
            // clm_NombreImagen
            // 
            this.clm_NombreImagen.HeaderText = "Nombre";
            this.clm_NombreImagen.Name = "clm_NombreImagen";
            this.clm_NombreImagen.ReadOnly = true;
            // 
            // clm_Ruta
            // 
            this.clm_Ruta.HeaderText = "Ruta";
            this.clm_Ruta.Name = "clm_Ruta";
            this.clm_Ruta.ReadOnly = true;
            // 
            // EliminarCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Codigo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCampaña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCampaña";
            this.Load += new System.EventHandler(this.EliminarCampaña_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Horarios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Imagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_VistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Wednesday;
        private System.Windows.Forms.CheckBox Friday;
        private System.Windows.Forms.CheckBox Saturday;
        private System.Windows.Forms.CheckBox Sunday;
        private System.Windows.Forms.CheckBox Thursday;
        private System.Windows.Forms.CheckBox Tuesday;
        private System.Windows.Forms.CheckBox Monday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbx_IntTiempo;
        private System.Windows.Forms.TextBox tbx_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGV_Horarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_HoraDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_HoraHasta;
        private System.Windows.Forms.TextBox tbx_FechaHasta;
        private System.Windows.Forms.TextBox tbx_FechaDesde;
        private System.Windows.Forms.DataGridView dGV_Imagenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pB_VistaPrevia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NombreImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Ruta;
    }
}