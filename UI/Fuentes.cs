﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Dominio.RSS;

namespace UI
{
	public partial class Fuentes : Form
	{
		private List<IFuente> iFuentes;
		private IFuente _Fuente;
		string iFuenteSeleccionada;

		public Fuentes()
		{
			InitializeComponent();
			iFuentes = new ControladorFuentes().ObtenerFuentes();
		}

		public Fuentes(string pDescripcion)
		{
			InitializeComponent();
			iFuenteSeleccionada = pDescripcion;
		}

		private void Fuentes_Load(object sender, EventArgs e)
		{
			fechaDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			fechaHasta.Value = fechaDesde.Value.AddMonths(1);
			CargarFuentes();
		}

		private void CargarFuentes()
		{
			iFuentes = new ControladorFuentes().ObtenerFuentes();

			cbx_Fuente.Items.Clear();

			for (int i = 0; i < iFuentes.Count; i++)
			{
				cbx_Fuente.Items.Add(iFuentes[i].Descripcion);
			}
		}

		private void CargarItems()
		{
			_Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
			tbxTipoFuente.Text = _Fuente.GetType().Name;

			if (tbxTipoFuente.Text != "FuenteRSS")
			{
				btnAgregarItem.Visible = true;
				btnModificarItem.Visible = true;
				btnEliminarItem.Visible = true;
				fechaDesde.Enabled = true;
				fechaHasta.Enabled = true;
				iItemBindingSource.DataSource = _Fuente.Items;
			}
			else
			{
				btnAgregarItem.Visible = false;
				btnModificarItem.Visible = false;
				btnEliminarItem.Visible = false;
				IRssReader mRssReader = new RawXmlRssReader();
				var items = mRssReader.Read(((FuenteRSS)_Fuente).URL).ToList();
				if (items.Count > 0)
				{
					new VentanaEmergente("Solicitud RSS exitosa", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
					iItemBindingSource.DataSource = items.ToList();
					new ControladorFuentes().ActualizarItemsRss(items, _Fuente.FuenteId);
					fechaDesde.Enabled = false;
					fechaHasta.Enabled = false;
				}
				else
				{
					fechaDesde.Enabled = true;
					fechaHasta.Enabled = true;
					new VentanaEmergente("No se obtuvieron items en la solicitud RSS", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
					iItemBindingSource.DataSource = _Fuente.Items;
				}
			}
			iItemBindingSource.ResetBindings(true);
		}

		private void btnNuevaFuente_Click(object sender, EventArgs e)
		{
			AddModFuente f = new AddModFuente();
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
				CargarFuentes();
		}

		private void btnModFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				AddModFuente f = new AddModFuente(_Fuente);
				f.ShowDialog();
				if (f.DialogResult == DialogResult.OK)
					CargarFuentes();
			}
		}

		private void btnEliminarFuente_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
			{
				try
				{
					if (_Fuente.FuenteId == 1)
						throw new Exception("La Fuente seleccionada no puede ser eliminada");

					VentanaEmergente ve = new VentanaEmergente("¿Desea eliminar la Fuente seleccionada?", VentanaEmergente.TipoMensaje.SiNo);
					ve.ShowDialog();
					if (ve.DialogResult == DialogResult.OK)
					{
						new ControladorFuentes().ABMFuente(
							ControladorFuentes.Operacion.Eliminar,
							tbxTipoFuente.Text,
							_Fuente.FuenteId,
							_Fuente.Descripcion,
							"");
						new VentanaEmergente("Fuente Eliminada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
						CargarFuentes();
					}
					ve.Dispose();
				}
				catch (Exception E)
				{
					new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
				}
			}
		}

		private void btnAgregarItem_Click(object sender, EventArgs e)
		{
			ItemsFuentes f = new ItemsFuentes(new ItemGenerico() { ItemId = 0, Fecha = DateTime.Now }, _Fuente.FuenteId);
			f.ShowDialog();
			if (f.DialogResult == DialogResult.OK)
				CargarFuentes();
		}

		private void ModificarItem_Click(object sender, EventArgs e)
		{
			if ((IItem)iItemBindingSource.Current != null)
			{
				ItemsFuentes f = new ItemsFuentes((IItem)iItemBindingSource.Current, _Fuente.FuenteId);
				iItemBindingSource.SuspendBinding();
				f.ShowDialog();
				if (f.DialogResult == DialogResult.OK)
					CargarFuentes();
				iItemBindingSource.ResumeBinding();
			}
		}

		private void btn_eliminarItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (iItemBindingSource.Current != null)
				{
					if (_Fuente.FuenteId == 1 && _Fuente.Items.Count == 1)
						throw new Exception("El Item de la Fuente seleccionada no puede ser eliminado");

					VentanaEmergente ve = new VentanaEmergente("¿Desea eliminar el Item seleccionado?", VentanaEmergente.TipoMensaje.SiNo);
					ve.ShowDialog();
					if (ve.DialogResult == DialogResult.OK)
					{
						new ControladorFuentes().ABMItems(
									ControladorFuentes.Operacion.Eliminar,
									_Fuente.FuenteId,
									(IItem)iItemBindingSource.Current);
						new VentanaEmergente("Item Eliminado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
						CargarFuentes();
					}
					ve.Dispose();
				}
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Close();
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
			CargarItems();
		}

		private void HoverLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true)[0].Visible = true;
		}

		private void LeaveLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true).First().Visible = false;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			btnBuscar.BorderStyle = BorderStyle.Fixed3D;
			Cursor = Cursors.WaitCursor;
			CargarItems();
			btnBuscar.BorderStyle = BorderStyle.None;
			Cursor = Cursors.Default;
		}

		private void btnBuscar_MouseHover(object sender, EventArgs e)
		{
			btnBuscar.BorderStyle = BorderStyle.FixedSingle;
		}

		private void btnBuscar_MouseLeave(object sender, EventArgs e)
		{
			btnBuscar.BorderStyle = BorderStyle.None;
		}
	}
}
