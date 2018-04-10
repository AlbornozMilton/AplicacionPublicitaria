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


using System.Diagnostics;
using System.IO;

namespace UI
{
    public partial class AgregarCampaña : Form
    {
        List<RangoHorario> horarios = new List<RangoHorario>();
        List<Imagen> imagenes = new List<Imagen>();


        List<Campania> campaniasHoy = new List<Campania>();

        public AgregarCampaña()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label11.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label13.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label12.Visible = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<Dia>DevolverDias(List<CheckBox> pDiasSeleccionados)
        {
            List<Dia> dias = new List<Dia>();
            foreach (var dia in pDiasSeleccionados)
            {
                if (dia.Checked)
                {
                    dias.Add(new Dia(dia.Name));
                }
            }
            return dias;
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            List<Dia> dias = DevolverDias(new List<CheckBox>() { Monday,Tuesday,cbx_Miercoles,cbx_Jueves,cbx_Viernes, Saturday,cbx_Domingo });
            new ControladorCampania().AgregarCampania(tbx_Nombre.Text, Convert.ToInt32(numUpDown_IntTiempo.Text),dtp_FechaDesde.Value, dtp_FechaHasta.Value,dias,horarios,imagenes);
        }

        private void btn_BorrarHora_Click(object sender, EventArgs e)
        {
            if (dgv_Horarios.CurrentRow != null)
            {
                dgv_Horarios.Rows.Remove(dgv_Horarios.CurrentRow);
            }
            //Agregar para que tambien borre de la lista HORARIOS
            //horarios.RemoveAt(dgv_Horarios.CurrentRow.Index);//andara?
        }

        private void btn_BorrarImagen_Click(object sender, EventArgs e)
        {
            if (dgv_Imagenes.CurrentRow != null)
            {
                dgv_Imagenes.Rows.Remove(dgv_Imagenes.CurrentRow);
            }
        }

        private void btn_AgregarHora_Click(object sender, EventArgs e)
        {
            horarios.Add(new RangoHorario((dtp_HoraDesde.Value.TimeOfDay),dtp_HoraHasta.Value.TimeOfDay));
            dgv_Horarios.Rows.Add(horarios.Last<RangoHorario>().HoraInicio.ToString("hh:mm") , horarios.Last<RangoHorario>().HoraFin.ToString("hh:mm"));
        }

        private void btn_AgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagenes = new OpenFileDialog();
            buscarImagenes.ShowDialog();
            if (buscarImagenes.FileName != "")
            {
                Imagen imagenSeleccionada = new Imagen(buscarImagenes.SafeFileName,buscarImagenes.FileName);
                imagenes.Add(imagenSeleccionada);
                dgv_Imagenes.Rows.Add(buscarImagenes.SafeFileName, buscarImagenes.FileName);
            }
        }

        private void btn_PantallaOp_Click(object sender, EventArgs e)
        {
            new PantallaOperativa().ShowDialog();
        }

        private void AgregarCampaña_Load(object sender, EventArgs e)
        {
            campaniasHoy = new ControladorCampania().ObtenerCampaniasParaElDia(DateTime.Today);
            Campania campañiaAhora = new ControladorCampania().ObtenerCampaniaActual(campaniasHoy);
        }
    }
}
