using System;
using System.Windows.Forms;
using Dominio.Interfaces;
using Dominio.Controladores;

namespace UI
{
	public partial class ItemsFuentes : Form
	{
		private static readonly log4net.ILog Loger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		private IItem _Item;
		private int _FuenteId;

		public ItemsFuentes(IItem pItem, int pFuenteId)
		{
			Loger.Info("Iniciando Item");
			InitializeComponent();
			_Item = pItem;
			_Item.Fecha = DateTime.Now;
			_FuenteId = pFuenteId;
		}

		private void ItemsFuentes_Load(object sender, EventArgs e)
		{
			_Item.Fecha.GetDateTimeFormats('g');
			iItemBindingSource.DataSource = _Item;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (tituloTextBox.Text != "" && textoTextBox.Text != "")
			{
				if (_Item.ItemId == 0)
				{
					new ControladorFuentes().ABMItems(ControladorFuentes.Operacion.Agregar, _FuenteId, _Item);
					new VentanaEmergente("Item Agregado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				else
				{
					new ControladorFuentes().ABMItems(ControladorFuentes.Operacion.Modificar, _FuenteId, _Item);
					new VentanaEmergente("Item Modificado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
				}
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Loger.Info("Cancelar");
			Close();
		}
	}
}
