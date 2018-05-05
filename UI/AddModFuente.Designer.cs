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
			this.lblFuente = new System.Windows.Forms.Label();
			this.lbl_tipoFuente = new System.Windows.Forms.Label();
			this.tbxNombreFuente = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.cbxTipoFuente = new System.Windows.Forms.ComboBox();
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
			// lblFuente
			// 
			this.lblFuente.AutoSize = true;
			this.lblFuente.BackColor = System.Drawing.Color.Transparent;
			this.lblFuente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFuente.ForeColor = System.Drawing.Color.White;
			this.lblFuente.Location = new System.Drawing.Point(15, 63);
			this.lblFuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFuente.Name = "lblFuente";
			this.lblFuente.Size = new System.Drawing.Size(123, 18);
			this.lblFuente.TabIndex = 40;
			this.lblFuente.Text = "Nombre Fuente";
			// 
			// lbl_tipoFuente
			// 
			this.lbl_tipoFuente.AutoSize = true;
			this.lbl_tipoFuente.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tipoFuente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tipoFuente.ForeColor = System.Drawing.Color.White;
			this.lbl_tipoFuente.Location = new System.Drawing.Point(42, 98);
			this.lbl_tipoFuente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_tipoFuente.Name = "lbl_tipoFuente";
			this.lbl_tipoFuente.Size = new System.Drawing.Size(96, 18);
			this.lbl_tipoFuente.TabIndex = 39;
			this.lbl_tipoFuente.Text = "Tipo Fuente";
			// 
			// tbxNombreFuente
			// 
			this.tbxNombreFuente.Location = new System.Drawing.Point(145, 64);
			this.tbxNombreFuente.Name = "tbxNombreFuente";
			this.tbxNombreFuente.Size = new System.Drawing.Size(467, 20);
			this.tbxNombreFuente.TabIndex = 41;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(531, 138);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(81, 33);
			this.btnCancelar.TabIndex = 44;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(433, 138);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 33);
			this.btnAceptar.TabIndex = 43;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// cbxTipoFuente
			// 
			this.cbxTipoFuente.FormattingEnabled = true;
			this.cbxTipoFuente.Location = new System.Drawing.Point(145, 95);
			this.cbxTipoFuente.Name = "cbxTipoFuente";
			this.cbxTipoFuente.Size = new System.Drawing.Size(136, 21);
			this.cbxTipoFuente.TabIndex = 45;
			this.cbxTipoFuente.SelectedIndexChanged += new System.EventHandler(this.cbxTipoFuente_SelectedIndexChanged);
			// 
			// AddModFuente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(624, 183);
			this.Controls.Add(this.cbxTipoFuente);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.tbxNombreFuente);
			this.Controls.Add(this.lblFuente);
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
		private System.Windows.Forms.Label lblFuente;
		private System.Windows.Forms.Label lbl_tipoFuente;
		private System.Windows.Forms.TextBox tbxNombreFuente;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.ComboBox cbxTipoFuente;
	}
}