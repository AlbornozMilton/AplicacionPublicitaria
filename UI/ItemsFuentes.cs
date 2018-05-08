using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class ItemsFuentes : Form
	{
		private IItem _Item;
		private int _FuenteId;

		public ItemsFuentes(IItem pItem, int pFuenteId)
		{
			InitializeComponent();
			_Item = pItem;
			_FuenteId = pFuenteId;
		}

		private void ItemsFuentes_Load(object sender, EventArgs e)
		{
			iItemBindingSource.DataSource = _Item;
			fechaDateTimePicker.MinDate = DateTime.Now;
			fechaDateTimePicker.Value = DateTime.Now;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (tituloTextBox.Text != "" && textoTextBox.Text != "")
			{
				if (_Item.ItemId == 0)
				{
					new ControladorBanner().ABMItems(ControladorBanner.Operacion.Agregar, _FuenteId, _Item);
					new VentanaEmergente("Item Agregado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				else
				{
					new ControladorBanner().ABMItems(ControladorBanner.Operacion.Modificar, _FuenteId, _Item);
					new VentanaEmergente("Item Modificado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				Close();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
