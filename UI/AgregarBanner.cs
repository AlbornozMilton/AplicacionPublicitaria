using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
	public partial class AgregarBanner : Form
	{
		public AgregarBanner()
		{
			InitializeComponent();
		}

		private void AgregarBanner_Load(object sender, EventArgs e)
		{

		}

		private void btnAgregarHorario_Click(object sender, EventArgs e)
		{

		}

		private void btnBorrarHorario_Click(object sender, EventArgs e)
		{

		}

		private void btnNuevaFuente_Click(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			//dipose antes
			Close();
		}

		private void btnFuentes_Click(object sender, EventArgs e)
		{
			new Fuentes("NombreFuenteSeleccionada").ShowDialog();
		}
	}
}