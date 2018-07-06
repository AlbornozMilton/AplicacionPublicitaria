﻿using System;
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
        ControladorCampania iControladorCampania=  new ControladorCampania();
        ControladorExtra iControladorExtra = new ControladorExtra();

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
        /// <summary>
        /// Devuelve una lista de dias en forma de string cuyo caracter delimitador es -
        /// </summary>
        /// <param name="pDiasSeleccionados"></param>
        /// <returns></returns>
        private string DevolverDias()
        {
            List<CheckBox> pDiasSeleccionados = new List<CheckBox>() { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
            string dias = "";
            foreach (var dia in pDiasSeleccionados)
            {
                if (dia.Checked)
                {
                    dias = dias+(dia.Name)+"-";
                }
            }
            return dias;
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string dias = DevolverDias();
                if (iControladorCampania.ControlCamposObligatorios(tbx_Nombre.Text, dias.Split('-').Count(), dgv_Horarios.Rows.Count, dgv_Imagenes.Rows.Count, numUD_IntTiempo.Value))
                {
                    LlenarListaImagenes(dgv_Imagenes); 
                    iControladorCampania.AgregarCampania(tbx_Nombre.Text, Convert.ToInt32(numUD_IntTiempo.Text), dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, dias, horarios, imagenes);
                    new VentanaEmergente("Campaña Guardada", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
                    Close();
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void btn_BorrarHora_Click(object sender, EventArgs e)
        {
            if (dgv_Horarios.CurrentRow != null)
            {
                horarios.RemoveAll(h => h.HoraInicio.ToString() == dgv_Horarios.CurrentRow.Cells[0].Value.ToString() + ":00");
                dgv_Horarios.Rows.Remove(dgv_Horarios.CurrentRow);
            }            
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
            try
            {
                TimeSpan horaDesde = new TimeSpan(dtp_HoraDesde.Value.Hour, dtp_HoraDesde.Value.Minute, 00);
                TimeSpan horaHasta = new TimeSpan(dtp_HoraHasta.Value.Hour, dtp_HoraHasta.Value.Minute, 00);
                if (horaHasta.TotalMinutes > horaDesde.TotalMinutes)
                {
                    if (iControladorCampania.ControlColisionHorarios(horarios, horaDesde, horaHasta))
                    {
                        iControladorExtra.ComprobarHorarioCampania(horaDesde, horaHasta, DevolverDias());
                        horarios.Add(new RangoHorario(horaDesde,horaHasta));
                        dgv_Horarios.Rows.Add(horarios.Last<RangoHorario>().HoraInicio.ToString(@"hh\:mm"), horarios.Last<RangoHorario>().HoraFin.ToString(@"hh\:mm"));
                    } 
                }
                else
                {
                    throw new Exception("La hora de fin debe ser mayor a la hora de inicio por al menos 1 minuto");
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void LlenarListaImagenes (DataGridView listaImagenes)
        {
            for (int i = 0; i < listaImagenes.Rows.Count; i++)
            {
                Imagen nuevaImagen = new Imagen(listaImagenes.Rows[i].Cells[0].Value.ToString(), listaImagenes.Rows[i].Cells[1].Value.ToString());
                imagenes.Add(nuevaImagen);
            }
        }

        private void btn_AgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagenes = new OpenFileDialog();
            buscarImagenes.ShowDialog();
            if (buscarImagenes.FileName != "")
            {
                dgv_Imagenes.Rows.Add(buscarImagenes.SafeFileName, buscarImagenes.FileName);
            }
        }

        private void AgregarCampaña_Load(object sender, EventArgs e)
        {

        }

        private void dtp_FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            iControladorExtra.ActualizarCampaniasEnRangoFecha(dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date);
            dgv_Horarios.Rows.Clear();
        }

        private void dtp_FechaHasta_ValueChanged(object sender, EventArgs e)
        {
            iControladorExtra.ActualizarCampaniasEnRangoFecha(dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date);
            dgv_Horarios.Rows.Clear();
            List<CheckBox> checksDias = new List<CheckBox>() { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
            checksDias.ForEach(c => c.Enabled = false);
            try
            {
                if ((DateTime.Compare(dtp_FechaDesde.Value.Date,dtp_FechaHasta.Value.Date)) > 0)
                {
                    throw new Exception("La fecha de fin deber ser mayor o igual a la fecha de inicio");
                }
                List<string> dias = iControladorCampania.DiasEntreFechas(dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date);
                foreach (var dia in checksDias)
                {
                    if (dias.Contains(dia.Name))
                    {
                        dia.Enabled = true;
                    }
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void dGV_Imagenes_SelectionChanged(object sender, EventArgs e)
        {
            string ruta = dgv_Imagenes.SelectedCells[1].Value.ToString();
            pB_VistaPrevia.Image = Image.FromFile(ruta);
        }

        private void btn_Subir_Click(object sender, EventArgs e)
        {
            if (dgv_Imagenes.SelectedRows.Count > 0 && dgv_Imagenes.CurrentRow.Index != 0)
            {
                var index = dgv_Imagenes.CurrentRow.Index;
                var fila = dgv_Imagenes.CurrentRow;
                dgv_Imagenes.Rows.Remove(fila);
                dgv_Imagenes.Rows.Insert(index - 1, fila);
                dgv_Imagenes.Rows[index - 1].Selected = true;
                dgv_Imagenes.Rows[index - 1].Cells[0].Selected = true;
                dgv_Imagenes.CurrentCellChanged += new EventHandler(dgv_Imagenes_CurrentCellChanged);
                dgv_Imagenes.SelectionChanged += new EventHandler(dGV_Imagenes_SelectionChanged);
            } 
        }

        private void btn_Abajo_Click(object sender, EventArgs e)
        {
            if (dgv_Imagenes.SelectedRows.Count > 0 && dgv_Imagenes.CurrentRow.Index +1 < dgv_Imagenes.Rows.Count)
            {
                var index = dgv_Imagenes.CurrentRow.Index;
                var fila = dgv_Imagenes.CurrentRow;
                dgv_Imagenes.Rows.Remove(fila);
                dgv_Imagenes.Rows.Insert(index + 1, fila);
                dgv_Imagenes.Rows[index + 1].Selected = true;
                dgv_Imagenes.Rows[index + 1].Cells[0].Selected = true;
                dgv_Imagenes.CurrentCellChanged += new EventHandler(dgv_Imagenes_CurrentCellChanged);
                dgv_Imagenes.SelectionChanged += new EventHandler(dGV_Imagenes_SelectionChanged);
            }
        }

        private void dgv_Imagenes_CurrentCellChanged(object sender, EventArgs e) { }

        //private void ControlFecha(int pBannerExcluido)
        //{
        //    try
        //    {
        //        //if (iBanner == null)
        //        //{
        //        //    dGV_horarios.Rows.Clear();
        //        //    iHorarios.Clear();
        //        //}
        //        iControladorExtra.ActualizarBannersEnRangoFecha(pBannerExcluido, fechaDesde.Value, fechaHasta.Value);
        //        //if (iBanner != null)
        //        //    iControlExtra.ComprobarHorarioBanner(iHorarios, iDias);
        //    }
        //    catch (ApplicationException)
        //    {
        //        //if (iBanner != null)
        //        //{
        //        //    fechaDesde.Value = iBanner.RangoFecha.FechaInicio;
        //        //    fechaHasta.Value = iBanner.RangoFecha.FechaFin;
        //        //}
        //        new VentanaEmergente("Para las fechas elegidas no se permiten los dias y/o horarios", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
        //    }
        //    catch (Exception E)
        //    {
        //        new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
        //    }
        //}
    }
}
