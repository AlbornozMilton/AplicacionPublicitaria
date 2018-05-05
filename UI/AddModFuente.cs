using System;
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
	public partial class AddModFuente : Form
	{
		private List<TipoFuente> iTiposFuente = new List<TipoFuente>() { TipoFuente.RSS, TipoFuente.TextoFijo }; 
		private IFuente iFuente;

		public AddModFuente()
		{
			InitializeComponent();
		}

		public AddModFuente(IFuente pFuente)
		{
			InitializeComponent();
			iFuente = pFuente;
		}

		private void AddModFuente_Load(object sender, EventArgs e)
		{
			if (iFuente != null)
			{
				cbxTipoFuente.SelectedText = iFuente.TipoFuente.ToString();
				if (iFuente.TipoFuente == TipoFuente.RSS)
					lblFuente.Text = "URL de Fuente";
			}
			else
			{
				foreach (TipoFuente tipoFuente in iTiposFuente)
				{
					cbxTipoFuente.Items.Add(tipoFuente);
				}
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (iFuente != null) // modificando
			{

			}
			else //nueva fuente
			{

			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbxTipoFuente_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxTipoFuente.SelectedItem.ToString() == "RSS")
				lblFuente.Text = "URL de Fuente";
			else
				lblFuente.Text = "Nombre Fuente";
		}
	}
}
