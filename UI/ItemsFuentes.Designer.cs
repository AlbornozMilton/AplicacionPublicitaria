namespace UI
{
	partial class ItemsFuentes
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
			System.Windows.Forms.Label tituloLabel;
			System.Windows.Forms.Label textoLabel;
			System.Windows.Forms.Label fechaLabel1;
			this.lbl_Title = new System.Windows.Forms.Label();
			this.tituloTextBox = new System.Windows.Forms.TextBox();
			this.iItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textoTextBox = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.fechaTextBox = new System.Windows.Forms.TextBox();
			tituloLabel = new System.Windows.Forms.Label();
			textoLabel = new System.Windows.Forms.Label();
			fechaLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.iItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tituloLabel
			// 
			tituloLabel.AutoSize = true;
			tituloLabel.Location = new System.Drawing.Point(41, 90);
			tituloLabel.Name = "tituloLabel";
			tituloLabel.Size = new System.Drawing.Size(46, 14);
			tituloLabel.TabIndex = 4;
			tituloLabel.Text = "Título:";
			// 
			// textoLabel
			// 
			textoLabel.AutoSize = true;
			textoLabel.Location = new System.Drawing.Point(41, 118);
			textoLabel.Name = "textoLabel";
			textoLabel.Size = new System.Drawing.Size(46, 14);
			textoLabel.TabIndex = 6;
			textoLabel.Text = "Texto:";
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.White;
			this.lbl_Title.Location = new System.Drawing.Point(16, 14);
			this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(218, 18);
			this.lbl_Title.TabIndex = 3;
			this.lbl_Title.Text = "Agregar/Modificar Item";
			// 
			// tituloTextBox
			// 
			this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iItemBindingSource, "Titulo", true));
			this.tituloTextBox.Location = new System.Drawing.Point(93, 87);
			this.tituloTextBox.Name = "tituloTextBox";
			this.tituloTextBox.Size = new System.Drawing.Size(437, 22);
			this.tituloTextBox.TabIndex = 1;
			// 
			// iItemBindingSource
			// 
			this.iItemBindingSource.DataSource = typeof(Dominio.IItem);
			// 
			// textoTextBox
			// 
			this.textoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iItemBindingSource, "Texto", true));
			this.textoTextBox.Location = new System.Drawing.Point(93, 115);
			this.textoTextBox.Multiline = true;
			this.textoTextBox.Name = "textoTextBox";
			this.textoTextBox.Size = new System.Drawing.Size(437, 96);
			this.textoTextBox.TabIndex = 2;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCancelar.Location = new System.Drawing.Point(449, 234);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(81, 33);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAceptar.Location = new System.Drawing.Point(351, 234);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 33);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// fechaLabel1
			// 
			fechaLabel1.AutoSize = true;
			fechaLabel1.Location = new System.Drawing.Point(38, 62);
			fechaLabel1.Name = "fechaLabel1";
			fechaLabel1.Size = new System.Drawing.Size(49, 14);
			fechaLabel1.TabIndex = 8;
			fechaLabel1.Text = "Fecha:";
			// 
			// fechaTextBox
			// 
			this.fechaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iItemBindingSource, "Fecha", true));
			this.fechaTextBox.Location = new System.Drawing.Point(93, 59);
			this.fechaTextBox.Name = "fechaTextBox";
			this.fechaTextBox.ReadOnly = true;
			this.fechaTextBox.Size = new System.Drawing.Size(193, 22);
			this.fechaTextBox.TabIndex = 9;
			// 
			// ItemsFuentes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::UI.Properties.Resources.FondoVentanas;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(557, 288);
			this.Controls.Add(fechaLabel1);
			this.Controls.Add(this.fechaTextBox);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(textoLabel);
			this.Controls.Add(this.textoTextBox);
			this.Controls.Add(tituloLabel);
			this.Controls.Add(this.tituloTextBox);
			this.Controls.Add(this.lbl_Title);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "ItemsFuentes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar/Modificar Item";
			this.Load += new System.EventHandler(this.ItemsFuentes_Load);
			((System.ComponentModel.ISupportInitialize)(this.iItemBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.BindingSource iItemBindingSource;
		private System.Windows.Forms.TextBox tituloTextBox;
		private System.Windows.Forms.TextBox textoTextBox;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox fechaTextBox;
	}
}