namespace UI
{
	partial class AddModFuente
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
			this.lbl_Title = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lbl_tipoFuente = new System.Windows.Forms.Label();
			this.tbxDescripcion = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.cbxTipoFuente = new System.Windows.Forms.ComboBox();
			this.txbUrl = new System.Windows.Forms.TextBox();
			this.lblUrl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.White;
			this.lbl_Title.Location = new System.Drawing.Point(13, 9);
			this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(237, 18);
			this.lbl_Title.TabIndex = 5;
			this.lbl_Title.Text = "Agregar/Modificar Fuente";
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
			this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescripcion.ForeColor = System.Drawing.Color.White;
			this.lblDescripcion.Location = new System.Drawing.Point(45, 84);
			this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(93, 18);
			this.lblDescripcion.TabIndex = 40;
			this.lblDescripcion.Text = "Descripción";
			// 
			// lbl_tipoFuente
			// 
			this.lbl_tipoFuente.AutoSize = true;
			this.lbl_tipoFuente.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tipoFuente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tipoFuente.ForeColor = System.Drawing.Color.White;
			this.lbl_tipoFuente.Location = new System.Drawing.Point(42, 56);
			this.lbl_tipoFuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_tipoFuente.Name = "lbl_tipoFuente";
			this.lbl_tipoFuente.Size = new System.Drawing.Size(96, 18);
			this.lbl_tipoFuente.TabIndex = 39;
			this.lbl_tipoFuente.Text = "Tipo Fuente";
			// 
			// tbxDescripcion
			// 
			this.tbxDescripcion.Font = new System.Drawing.Font("Verdana", 9F);
			this.tbxDescripcion.Location = new System.Drawing.Point(145, 84);
			this.tbxDescripcion.Name = "tbxDescripcion";
			this.tbxDescripcion.Size = new System.Drawing.Size(457, 22);
			this.tbxDescripcion.TabIndex = 0;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(521, 144);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(81, 33);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(419, 145);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 33);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// cbxTipoFuente
			// 
			this.cbxTipoFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipoFuente.Font = new System.Drawing.Font("Verdana", 9F);
			this.cbxTipoFuente.FormattingEnabled = true;
			this.cbxTipoFuente.Location = new System.Drawing.Point(145, 53);
			this.cbxTipoFuente.Name = "cbxTipoFuente";
			this.cbxTipoFuente.Size = new System.Drawing.Size(136, 22);
			this.cbxTipoFuente.TabIndex = 0;
			this.cbxTipoFuente.SelectedIndexChanged += new System.EventHandler(this.cbxTipoFuente_SelectedIndexChanged);
			// 
			// txbUrl
			// 
			this.txbUrl.Font = new System.Drawing.Font("Verdana", 9F);
			this.txbUrl.Location = new System.Drawing.Point(145, 117);
			this.txbUrl.Name = "txbUrl";
			this.txbUrl.Size = new System.Drawing.Size(457, 22);
			this.txbUrl.TabIndex = 41;
			this.txbUrl.Visible = false;
			this.txbUrl.Leave += new System.EventHandler(this.txbUrl_Leave);
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.BackColor = System.Drawing.Color.Transparent;
			this.lblUrl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUrl.ForeColor = System.Drawing.Color.White;
			this.lblUrl.Location = new System.Drawing.Point(101, 117);
			this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(37, 18);
			this.lblUrl.TabIndex = 42;
			this.lblUrl.Text = "URL";
			this.lblUrl.Visible = false;
			// 
			// AddModFuente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(624, 189);
			this.Controls.Add(this.lblUrl);
			this.Controls.Add(this.txbUrl);
			this.Controls.Add(this.cbxTipoFuente);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.tbxDescripcion);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.lbl_tipoFuente);
			this.Controls.Add(this.lbl_Title);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddModFuente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddModFuente";
			this.Load += new System.EventHandler(this.AddModFuente_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label lbl_tipoFuente;
		private System.Windows.Forms.TextBox tbxDescripcion;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.ComboBox cbxTipoFuente;
		private System.Windows.Forms.TextBox txbUrl;
		private System.Windows.Forms.Label lblUrl;
	}
}