﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class Fuentes : Form
	{
		private List<IFuente> iFuentes;

		public Fuentes()
		{
			InitializeComponent();
			iFuentes = new ControladorBanner().ObtenerFuentes();
		}

		public Fuentes(string pNombreFuente, List<IFuente> pFuentes )
		{
			InitializeComponent();
			iFuentes = pFuentes;
		}

		private void Fuentes_Load(object sender, EventArgs e)
		{
			foreach (var item in iFuentes)
			{
				cbx_Fuente.Items.Add(item.NombreFuente);
			}
		}

		private void btnNuevaFuente_Click(object sender, EventArgs e)
		{
			new AddModFuente().ShowDialog();
		}

		private void btnModFuente_Click(object sender, EventArgs e)
		{

		}

		private void btnEliminarFuente_Click(object sender, EventArgs e)
		{

		}

		private void btnAgregarItem_Click(object sender, EventArgs e)
		{
			new ItemsFuentes().ShowDialog();
		}

		private void ModificarItem_Click(object sender, EventArgs e)
		{
			new ItemsFuentes("TituloItem").ShowDialog();
		}

		private void btn_eliminarItem_Click(object sender, EventArgs e)
		{

		}

		private void btnTodosItems_Click(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{

		}

		private void lblX_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void lbl__Click(object sender, EventArgs e)
		{
            this.WindowState = FormWindowState.Minimized;
		}

		private void cbx_Fuente_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbxTipoFuente.Text = iFuentes.ElementAt(cbx_Fuente.SelectedIndex).GetType().Name;
		}
	}
}
