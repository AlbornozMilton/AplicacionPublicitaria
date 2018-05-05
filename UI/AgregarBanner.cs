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
		private List<Banner> iBanners;
		private List<IFuente> iFuentes; //llenarlas con el contrador 
		private string iDias;
		private List<DayOfWeek> iDias2 = new List<DayOfWeek>();

		public AgregarBanner()
		{
			InitializeComponent();
		}

		private void AgregarBanner_Load(object sender, EventArgs e)
		{
			//llebar el combox de fuentes
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
		}

		private void btnNuevaFuente_Click(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (dGV_itemsFuente.Rows.Count == 0)
					throw new Exception("Debe elegir al menos un Item a mostrar");

				//quitar el ultimo guion para que el Split no genere un elemento vacio demás
				iDias = iDias.Substring(0, iDias.Length - 1);
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
			new Fuentes("NombreFuenteSeleccionada").ShowDialog();
		}

		private void ControlFecha(object sender, EventArgs e)
		{
			if (fechaHasta.Value.Date > fechaDesde.Value.Date)
			{
				gbxDias.Enabled = true;
				gbxHorarios.Enabled = true;
				// rellenar los banners desde de la bd con las fechas indicadas
			}
			else
			{
				//cartel -fecha hasta debe ser mayor a fecha desde - y deshabilitar botones 
				gbxDias.Enabled = false;
				gbxHorarios.Enabled = false;
			}
		}

		private void ControlHorarios()
		{
			try
			{
				if (horaDesde.Value >= horaHasta.Value) //no permitido
				{
					//avisar de horario no permitido
					cbx_FuenteRss.Enabled = false;
				}
				else
				{
					//cotrol de que el horario no exita o no halla interseccion en propia grilla
					//control de horario en la lista banner
					var x = dGV_horarios.Rows[1];
					foreach (DataGridViewRow row in dGV_horarios.Rows)
					{
						//if (hay interseccion de horarios)
							cbx_FuenteRss.Enabled = false;
							//throw new exception
					}

					//agregar horario a la lista de horario o al controlador
					dGV_horarios.Rows.Add(horaDesde.Value.ToString(), horaHasta.Value.ToString());
					cbx_FuenteRss.Enabled = true;
				}

				if (dGV_horarios.Rows.Count == 0)
					cbx_FuenteRss.Enabled = false;
				else
					cbx_FuenteRss.Enabled = true;
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
			}

		}

		private void ckb_luenes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_luenes.Checked)
				//iDias += "lunes-";
				iDias2.Add(DayOfWeek.Monday);
			else
				iDias2.Remove(DayOfWeek.Monday);
				//iDias.Replace("lunes-", "");
			ControlDias();
		}

		private void ckb_martes_CheckedChanged(object sender, EventArgs e)
		{
			if (ckb_martes.Checked)
				iDias += "martes-";
			else
				iDias.Replace("martes-", "");
			var x = iDias.Split('-');
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
			//previamente debe llenarse el conbox en el load con las fuentes
			//completar el textbox TipoFuente
			//llenar data grid view con los ites de la fuente - DataSource
		}
	}
}