using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio.Modelos;
using Dominio.Controladores;

namespace UI
{
    public partial class BuscarCampaña : Form
    {
        //private static readonly log4net.ILog Looger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ControladorCampania iControladorCampania = new ControladorCampania();
        private List<Campania> iListaCampanias = new List<Campania>();
        public Campania iCampaniaSeleccionada;

        public BuscarCampaña()
        {
            MyLogger4Net.Logger.Debug("Buscando campañas");
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MyLogger4Net.Logger.Debug("Busqueda de campañas cancelada"); 
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            MyLogger4Net.Logger.Debug("Busqueda de campañas cancelada");
            Close();
        }

        private void Cargar_dGV()
        {
            for (int i = 0; i < iListaCampanias.Count(); i++)
            {
                dGV_Campanias.Rows.Insert(i, iListaCampanias[i].Nombre, iListaCampanias[i].RangoFecha.FechaInicio, iListaCampanias[i].RangoFecha.FechaFin);
            }

        }

        private void EliminarCampañia_Load(object sender, EventArgs e)
        {
            dGV_Campanias.AutoGenerateColumns = false;
            btn_Filtrar_Click(null, null);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV_Campanias.CurrentRow == null)
                {
                    throw new Exception("Se debe selecionar una Campaña");
                }
                else
                {
                    int i = dGV_Campanias.CurrentRow.Index;
                    this.iCampaniaSeleccionada = iListaCampanias[i];
                    MyLogger4Net.Logger.Debug("Campaña buscada seleccionada");
                    Close();
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }
     
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
			btn_Filtrar.BorderStyle = BorderStyle.Fixed3D;

			Dictionary<Type, object> filtros = new Dictionary<Type, object>();
            string nombre = "";
            if (this.CB_Nombre.Checked)
            {
                nombre = this.TB_Nombre.Text;
            }
            filtros.Add(nombre.GetType(), nombre);
            if (this.CB_RangoFecha.Checked)
            {
                RangoFecha pRangoFecha = new RangoFecha(this.dtp_FechaDesde.Value, this.dtp_FechaHasta.Value, "", null);
                filtros.Add(pRangoFecha.GetType(), pRangoFecha);
            }
            iListaCampanias = iControladorCampania.ObtenerCampaniasFiltradas(filtros);
            dGV_Campanias.Rows.Clear();
            Cargar_dGV();
            MyLogger4Net.Logger.Debug("Filtrando busqueda de campañas");
            btn_Filtrar.BorderStyle = BorderStyle.Fixed3D;
		}

        private void CB_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Nombre.Checked == true)
            {
                TB_Nombre.Enabled = true;            
            }
            else
            {
                TB_Nombre.Enabled = false;
            }
        }

        private void CB_RangoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_RangoFecha.Checked == true)
            {
                dtp_FechaDesde.Enabled = true;
                dtp_FechaHasta.Enabled = true;
            }
            else
            {
                dtp_FechaDesde.Enabled = false;
                dtp_FechaHasta.Enabled = false;
            }
        }

        private void dtp_FechaHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((DateTime.Compare(dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date)) > 0)
                {
                    throw new Exception("La fecha de fin deber ser mayor o igual a la fecha de inicio");
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }

		private void btn_Filtrar_MouseHover(object sender, EventArgs e)
		{
			btn_Filtrar.BorderStyle = BorderStyle.FixedSingle;
		}

		private void btn_Filtrar_MouseLeave(object sender, EventArgs e)
		{
			btn_Filtrar.BorderStyle = BorderStyle.None;
		}
	}
}
