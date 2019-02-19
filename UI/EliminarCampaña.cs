using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dominio.Modelos;
using Dominio.Controladores;

namespace UI
{
    public partial class EliminarCampaña : Form
    {
        private Campania iCampaniaParaEliminar;

        private ControladorCampania iControladorCampania = new ControladorCampania();


        public EliminarCampaña(Campania pCampania)
        {
            InitializeComponent();
            MyLogger4Net.Logger.Debug("Eliminando Campaña");
            this.iCampaniaParaEliminar = pCampania;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MyLogger4Net.Logger.Debug("Eliminación de Campaña Cancelada");
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
            MyLogger4Net.Logger.Debug("Eliminación de Campaña Cancelada");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            iControladorCampania.EliminarCampania(this.iCampaniaParaEliminar.CampaniaId);
            new VentanaEmergente("Campaña Eliminada Correctamente", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
            MyLogger4Net.Logger.Debug("Campaña Eliminada");
            Close();
        }
        private void Cargar_Imagenes()
        {
            foreach (var imagen in iCampaniaParaEliminar.Imagenes)
            {
                dGV_Imagenes.Rows.Add(imagen.Nombre, imagen.Ruta);
            }
        }

        private void Cargar_Horarios()
        {
            foreach (var hora in iCampaniaParaEliminar.RangoFecha.Horarios)
            {
                dGV_Horarios.Rows.Add(hora.HoraInicio,hora.HoraFin);
            }
        }

        private void Cargar_Dias()
        {
            List<CheckBox> diasChecks = new List<CheckBox>() { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
            List<string> dias = iCampaniaParaEliminar.RangoFecha.Dias.Split('-').ToList();
            foreach (var check in diasChecks)
            {
                if (dias.Contains(check.Name))
                {
                    check.Checked = true;
                }
            }
        }

        private void CargarCampos()
        {
            tbx_Nombre.Text = iCampaniaParaEliminar.Nombre;
            tbx_Codigo.Text = iCampaniaParaEliminar.CampaniaId.ToString();
            tbx_FechaDesde.Text = iCampaniaParaEliminar.RangoFecha.FechaInicio.ToString("dd/MM/yyyy");
            tbx_FechaHasta.Text = iCampaniaParaEliminar.RangoFecha.FechaFin.ToString("dd/MM/yyyy");
            tbx_IntTiempo.Text = iCampaniaParaEliminar.IntervaloTiempo.ToString();
            Cargar_Dias();
            Cargar_Imagenes();
            Cargar_Horarios();
        }

        private void EliminarCampaña_Load(object sender, EventArgs e)
        {
            CargarCampos();
        }

        private void dGV_Imagenes_SelectionChanged(object sender, EventArgs e)
        {
            string ruta = dGV_Imagenes.CurrentRow.Cells[1].Value.ToString();
            pB_VistaPrevia.Image = Image.FromFile(ruta);
        }
    }
}
