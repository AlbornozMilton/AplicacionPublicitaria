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
	public partial class AgregarBanner : Form
	{
		//private List<Banner> iBannersEnRan;
		private ControladorExtra iControlExtra = new ControladorExtra();
		private List<IFuente> iFuentes = new List<IFuente>(); 
		private string iDias;

		public AgregarBanner()
		{
			InitializeComponent();
		}

		private void AgregarBanner_Load(object sender, EventArgs e)
		{
			iFuentes = new ControladorBanner().ObtenerFuentes();// solo nombres de fuente
			foreach (IFuente fuente in iFuentes)
			{
				cbx_Fuente.Items.Add(fuente.NombreFuente);
			}
		}

		private void btnAgregarHorario_Click(object sender, EventArgs e)
		{
			ControlHorarios();
		}

		private void btnBorrarHorario_Click(object sender, EventArgs e)
		{
			if (dGV_itemsFuente.CurrentRow != null)
			{
				//lista de horarios eliminar donde el current row sea igual
				dGV_itemsFuente.Rows.Remove(dGV_itemsFuente.CurrentRow);
			}

			if (dGV_horarios.Rows.Count == 0)
				cbx_Fuente.Enabled = false;
			else
				cbx_Fuente.Enabled = true;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dGV_itemsFuente.Rows.Count == 0)
					throw new Exception("Debe elegir al menos un Item a mostrar");

				//quitar el ultimo guion para que el Split no genere un elemento vacio demás
				//iDias = iDias.Split('-',StringSplitOptions.RemoveEmptyEntries);
				//generar lista de horarios a partir de la datagrid
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			//dipose antes
			Close();
		}

		private void btnFuentes_Click(object sender, EventArgs e)
		{
			if (cbx_Fuente.SelectedItem != null)
				new Fuentes(cbx_Fuente.SelectedItem.ToString(), iFuentes).ShowDialog(); 
			else
				new Fuentes("",iFuentes).ShowDialog();
		}

		private void ControlFecha(object sender, EventArgs e)
		{
			try
			{
				if (fechaHasta.Value.Date <= fechaDesde.Value.Date)
				{
					gbxDias.Enabled = false;
					gbxHorarios.Enabled = false;
					throw new Exception("La Fecha Desde tiene que ser mayor que la Fecha Hasta");
				}

				iControlExtra.ActualizarBannersEnRangoFecha(fechaDesde.Value, fechaHasta.Value);
				gbxDias.Enabled = true;
				gbxHorarios.Enabled = true;
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void ControlHorarios()
		{
			try
			{
				if (horaDesde.Value >= horaHasta.Value) //no permitido
				{
					cbx_Fuente.Enabled = false;
					throw new Exception("La Hora Desde tiene que ser menor que la Hora Hasta");
				}

				//Control de que no exista en la grilla
				var x = dGV_horarios.Rows[1];
				foreach (DataGridViewRow row in dGV_horarios.Rows)
				{
					//if (hay interseccion de horarios)
					cbx_Fuente.Enabled = false;
					throw new Exception("El Horario elegido ya se encutran en la grilla");
				}

				//cotrol de que no halla interseccion en los banners de bd
				iControlExtra.ComprobarHorarioBanner(horaDesde.Value, horaHasta.Value, iDias);

				//agregar horario a la lista de horario o al controlador
				dGV_horarios.Rows.Add(horaDesde.Value.ToString(), horaHasta.Value.ToString());
				cbx_Fuente.Enabled = true;
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}
		}

		private void ckb_luenes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_luenes.Checked)
				iDias += "lunes-";
			else
				iDias.Replace("lunes-", "");
			ControlDias();
		}

		private void ckb_martes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_martes.Checked)
				iDias += "martes-";
			else
				iDias.Replace("martes-", "");
			ControlDias();
		}

		private void ckb_miercoles_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_miercoles.Checked)
				iDias += "miercoles-";
			else
				iDias.Replace("miercoles-", "");
			ControlDias();
		}

		private void ckb_jueves_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_jueves.Checked)
				iDias += "jueves-";
			else
				iDias.Replace("jueves-", "");
			ControlDias();
		}

		private void ckb_viernes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_viernes.Checked)
				iDias += "viernes-";
			else
				iDias.Replace("viernes-", "");
			ControlDias();
		}

		private void ckb_sabado_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_sabado.Checked)
				iDias += "sabado-";
			else
				iDias.Replace("sabado-", "");
			ControlDias();
		}

		private void ckb_domingo_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_domingo.Checked)
				iDias += "domingo-";
			else
				iDias.Replace("domingo-", "");
			ControlDias();
		}

		private void ControlDias()
		{
			if (iDias == "")
				gbxHorarios.Enabled = false;
			else
				gbxHorarios.Enabled = true;
		}

		private void HoverLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true)[0].Visible = true;
		}

		private void LeaveLabel(object sender, EventArgs e)
		{
			Controls.Find(((PictureBox)sender).Name.Replace("btn", ""), true).First().Visible = false;
		}

		private void cbx_FuenteRss_SelectedIndexChanged(object sender, EventArgs e)
		{
			IFuente _Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
			txbTipoFuente.Text = _Fuente.GetType().Name;

			if (txbTipoFuente.Text != "FuenteRSS")
			{
				//btnAgregarItem.Visible = true;
				//btnModificarFuente.Visible = true;
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteTexto(_Fuente.FuenteId);
			}
			else
			{
				//btnAgregarItem.Visible = false;
				//btnModificarFuente.Visible = false;
				iItemBindingSource.DataSource = new ControladorBanner().ItemsFuenteRss(_Fuente.FuenteId);
			}
		}
	}
}