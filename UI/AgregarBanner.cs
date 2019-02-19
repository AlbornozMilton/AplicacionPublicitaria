using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio.Modelos;
using Dominio.RSS;
using Dominio.Interfaces;
using Dominio.Controladores;


namespace UI
{
    public partial class AgregarBanner : Form
    {
        ControladorBanner iControladorBanner = new ControladorBanner();
        BannerRangoFecha iBannerRangoFecha = new BannerRangoFecha();
        List<RangoHorario> iHorarios = new List<RangoHorario>();
        List<IFuente> iFuentes = new List<IFuente>();
        IFuente _Fuente;
        Banner iBanner;
        string iDias = "";

        public AgregarBanner()
        {
            MyLogger4Net.Logger.Info("Generando nuevo Banner");
            InitializeComponent();
        }

        public AgregarBanner(Banner pBanner)
        {
            MyLogger4Net.Logger.Info("Modificando Banner");
            InitializeComponent();
            iBanner = pBanner;
        }

        private void AgregarBanner_Load(object sender, EventArgs e)
        {
            dGV_horarios.AllowUserToOrderColumns = true;
            RellenarFuentes();
            horaHasta.Value = DateTime.Now.AddHours(1);
            fechaHasta.Value = DateTime.Now.AddMonths(1);
            cbx_Fuente.SelectedIndex = 0;

            if (iBanner != null)
            {
                fechaDesde.Value = iBanner.RangoFecha.FechaInicio;
                fechaHasta.Value = iBanner.RangoFecha.FechaFin;

                cbx_Fuente.SelectedIndex = iFuentes.IndexOf(iFuentes.Where(f => f.FuenteId == iBanner.Fuente.FuenteId).First());

                tbxNombreBanner.Text = iBanner.Nombre;

                string[] mDias = iBanner.RangoFecha.Dias.Split('-');
                foreach (string item in mDias)
                {
                    if (item == "lunes")
                        ckb_luenes.Checked = true;
                    else if (item == "martes")
                        ckb_martes.Checked = true;
                    else if (item == "miercoles")
                        ckb_miercoles.Checked = true;
                    else if (item == "jueves")
                        ckb_jueves.Checked = true;
                    else if (item == "viernes")
                        ckb_viernes.Checked = true;
                    else if (item == "sabado")
                        ckb_sabado.Checked = true;
                    else
                        ckb_domingo.Checked = true;
                }

                iHorarios = iBanner.RangoFecha.Horarios;
                foreach (var item in iHorarios)
                {
                    dGV_horarios.Rows.Add(item.HoraInicio, item.HoraFin);
                }

                iControladorBanner.ActualizarBannersEnRangoFecha(iBanner.BannerId, fechaDesde.Value, fechaHasta.Value, iBannerRangoFecha);
            }
            else
                iControladorBanner.ActualizarBannersEnRangoFecha(0, fechaDesde.Value, fechaHasta.Value, iBannerRangoFecha);
        }

        private void RellenarFuentes()
        {
            cbx_Fuente.Items.Clear();
            iFuentes = new ControladorFuentes().ObtenerFuentes();
            foreach (IFuente fuente in iFuentes)
            {
                cbx_Fuente.Items.Add(fuente.Descripcion);
            }
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            MyLogger4Net.Logger.Debug("Control de Horarios");
            ControlHorarios();
        }

        private void btnBorrarHorario_Click(object sender, EventArgs e)
        {
            if (dGV_horarios.CurrentRow != null)
            {
                string[] horaInicio = dGV_horarios.CurrentRow.Cells[0].Value.ToString().Split(':');
                string[] horaFin = dGV_horarios.CurrentRow.Cells[1].Value.ToString().Split(':');
                TimeSpan horaInicioTime = new TimeSpan(Convert.ToInt32(horaInicio[0]), Convert.ToInt32(horaInicio[1]), 0);
                TimeSpan horaFinTime = new TimeSpan(Convert.ToInt32(horaFin[0]), Convert.ToInt32(horaFin[1]), 0);
                RangoHorario rh = new RangoHorario(horaInicioTime, horaFinTime);
                iHorarios.Remove(iHorarios.Where(h => h.HoraInicio == rh.HoraInicio && h.HoraFin == rh.HoraFin).SingleOrDefault());
                if (iBanner != null)
                    iBanner.RangoFecha.Horarios.Remove(iBanner.RangoFecha.Horarios.Where(h => h.HoraInicio == rh.HoraInicio && h.HoraFin == rh.HoraFin).SingleOrDefault());
                dGV_horarios.Rows.Remove(dGV_horarios.CurrentRow);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNombreBanner.Text == "")
                    throw new Exception("Debe rellenar el campo Nombre");

                if ((DateTime.Compare(fechaDesde.Value.Date, fechaHasta.Value.Date)) > 0)
                {
                    throw new Exception("La fecha de fin deber ser mayor o igual a la fecha de inicio");
                }

                if (iDias == "" || iDias == null)
                    throw new Exception("Debe elegir al menos un Día");

                if (dGV_horarios.Rows.Count == 0)
                    throw new Exception("Debe elegir al menos un Horario");

                if (txbTipoFuente.Text == "")
                    throw new Exception("Debe elegir una Fuente");

                VentanaEmergente f = null;
                if (dGV_itemsFuente.Rows.Count == 0)
                {
                    f = new VentanaEmergente("Se asignaran items de fuente por defecto en tiempo de operativa \n \n ¿Desea continuar?", VentanaEmergente.TipoMensaje.SiNo);
                    f.ShowDialog();
                }

                if (cbx_Fuente.SelectedItem == null)
                {
                    f = new VentanaEmergente("Debe elegir una Fuente", VentanaEmergente.TipoMensaje.Alerta);
                    f.ShowDialog();
                    return;
                }

                if (dGV_itemsFuente.Rows.Count > 0 || f.DialogResult == DialogResult.OK)
                {
                    iDias = "";
                    if (ckb_luenes.Checked)
                        iDias += "lunes-";
                    if (ckb_martes.Checked)
                        iDias += "martes-";
                    if (ckb_miercoles.Checked)
                        iDias += "miercoles-";
                    if (ckb_jueves.Checked)
                        iDias += "jueves-";
                    if (ckb_viernes.Checked)
                        iDias += "viernes-";
                    if (ckb_sabado.Checked)
                        iDias += "sabado-";
                    if (ckb_domingo.Checked)
                        iDias += "domingo-";
                    iDias = iDias.Remove(iDias.Length - 1);

                    if (iBanner != null)
                    {
                        new ControladorBanner().ModificarBanner(iBanner.BannerId, tbxNombreBanner.Text, iFuentes.ElementAt(cbx_Fuente.SelectedIndex).FuenteId, fechaDesde.Value, fechaHasta.Value, iHorarios.OrderBy(h => h.HoraInicio).ToList(), iDias);
                        new VentanaEmergente("Banner Modificado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
                    }
                    else
                    {
                        new ControladorBanner().AgregarBanner(tbxNombreBanner.Text, iFuentes.ElementAt(cbx_Fuente.SelectedIndex).FuenteId, fechaDesde.Value, fechaHasta.Value, iHorarios.OrderBy(h => h.HoraInicio).ToList(), iDias);
                        new VentanaEmergente("Banner Agregado", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
                    }
                    Close();
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFuentes_Click(object sender, EventArgs e)
        {
            new Fuentes(cbx_Fuente.SelectedText).ShowDialog();
            RellenarFuentes();
        }

        private void ControlFecha()
        {
            try
            {
                if ((DateTime.Compare(fechaDesde.Value.Date, fechaHasta.Value.Date)) > 0)
                {
                    throw new Exception("La fecha de fin deber ser mayor o igual a la fecha de inicio");
                }

                MyLogger4Net.Logger.Info("Reseteando valores de UI");
                iHorarios.Clear();
                dGV_horarios.Rows.Clear();
                iDias = "";
                ckb_luenes.Checked = false;
                ckb_martes.Checked = false;
                ckb_miercoles.Checked = false;
                ckb_jueves.Checked = false;
                ckb_viernes.Checked = false;
                ckb_sabado.Checked = false;
                ckb_domingo.Checked = false;

                if (iBanner == null)
                {
                    MyLogger4Net.Logger.Debug("Reset para nuevo Banner");
                    iControladorBanner.ActualizarBannersEnRangoFecha(0, fechaDesde.Value, fechaHasta.Value, iBannerRangoFecha);

                }
                else
                {
                    MyLogger4Net.Logger.Debug("Reset para modificar Banner");
                    iBanner.RangoFecha.Horarios.Clear();
                    iControladorBanner.ActualizarBannersEnRangoFecha(iBanner.BannerId, fechaDesde.Value, fechaHasta.Value, iBannerRangoFecha);
                }
            }
            catch (ApplicationException)
            {
                if (iBanner != null)
                {
                    fechaDesde.Value = iBanner.RangoFecha.FechaInicio;
                    fechaHasta.Value = iBanner.RangoFecha.FechaFin;
                }
                new VentanaEmergente("Para las fechas elegidas no se permiten los dias y/o horarios", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
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
                TimeSpan desde, hasta;
                desde = new TimeSpan(horaDesde.Value.Hour, horaDesde.Value.Minute, 0);
                hasta = new TimeSpan(horaHasta.Value.Hour, horaHasta.Value.Minute, 0);

                if (desde.CompareTo(hasta) >= 0)
                    throw new Exception("La Hora Desde tiene que ser menor que la Hora Hasta");

                foreach (RangoHorario item in iHorarios)
                {
                    if (!(item.HoraInicio.CompareTo(desde) > 0 && item.HoraInicio.CompareTo(hasta) >= 0)
                        &&
                        (!(item.HoraFin.CompareTo(desde) <= 0 && item.HoraFin.CompareTo(hasta) < 0)))
                        throw new Exception("Horario ya seleccionado");
                }

                iHorarios.Add(new RangoHorario(desde, hasta));
                iBannerRangoFecha.ComprobarHorarioBanner(iHorarios, iDias);
                MyLogger4Net.Logger.Info("Éxito en el Control de Horarios");
                dGV_horarios.Rows.Add(desde.ToString("hh\\:mm"), hasta.ToString("hh\\:mm"));
            }
            catch (ApplicationException E)
            {
                iHorarios.RemoveAt(iHorarios.Count - 1);
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
            catch (Exception E)
            {
                MyLogger4Net.Logger.Error(E.Message);
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void ControlCheckedDia(string pDia, object sender)
        {
            try
            {
                MyLogger4Net.Logger.Debug("Control check del día " + pDia);
                iBannerRangoFecha.ComprobarHorarioBanner(iHorarios, iDias += pDia);
            }
            catch (ApplicationException E)
            {
                MyLogger4Net.Logger.Info("Fallo en el control de check del día" + pDia);

                iDias = iDias.Replace(pDia, "");
                ((CheckBox)sender).Checked = false;
                MyLogger4Net.Logger.Info(E.Message);
                new VentanaEmergente(E.Message, VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
            }
        }
        private void ckb_luenes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_luenes.Checked)
                ControlCheckedDia("lunes-", sender);
            else
                iDias = iDias.Replace("lunes-", "");
        }

        private void ckb_martes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_martes.Checked)
                ControlCheckedDia("martes-", sender);
            else
                iDias = iDias.Replace("martes-", "");
        }

        private void ckb_miercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_miercoles.Checked)
                ControlCheckedDia("miercoles-", sender);
            else
                iDias = iDias.Replace("miercoles-", "");
        }

        private void ckb_jueves_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_jueves.Checked)
                ControlCheckedDia("jueves-", sender);
            else
                iDias = iDias.Replace("jueves-", "");
        }

        private void ckb_viernes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_viernes.Checked)
                ControlCheckedDia("viernes-", sender);
            else
                iDias = iDias.Replace("viernes-", "");
        }

        private void ckb_sabado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sabado.Checked)
                ControlCheckedDia("sabado-", sender);
            else
                iDias = iDias.Replace("sabado-", "");
        }

        private void ckb_domingo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_domingo.Checked)
                ControlCheckedDia("domingo-", sender);
            else
                iDias = iDias.Replace("domingo-", "");
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
            CargarItems();
        }

        private void CargarItems()
        {
            try
            {
                _Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
                txbTipoFuente.Text = _Fuente.GetType().Name;

                MyLogger4Net.Logger.Info("Tipo Fuente elegida " + txbTipoFuente.Text);
                if (txbTipoFuente.Text != "FuenteRSS")
                {
                    pictureBox1.Visible = false;
                    txlabel_peticionRss.Visible = false;
                    iItemBindingSource.DataSource = new ControladorFuentes().ItemsFuenteTexto(_Fuente.FuenteId, null, null);
                }
                else
                {
                    txlabel_peticionRss.Visible = true;
                    pictureBox1.Visible = true;
                    iItemBindingSource.Clear();
                }

                iItemBindingSource.ResetBindings(true);
            }
            catch
            {
                new VentanaEmergente("No se ha podido establecer conexión a RSS", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
                RssSinItems((FuenteRSS)iFuentes.ElementAt(cbx_Fuente.SelectedIndex));
            }
        }

        private void RssSinItems(FuenteRSS _Fuente)
        {
            string msg = "";
            _Fuente.Items.Clear();
            var itemsRss = new ControladorFuentes().ItemsFuenteRss(_Fuente.FuenteId, null, null);

            if (itemsRss.Count > 0)
            {
                MyLogger4Net.Logger.Debug("Items anteriores en BD para la Fuente seleccionada");
                _Fuente.Items.AddRange(itemsRss.OrderByDescending(f => f.Fecha));
                msg = "Se asignaron los items locales de la última petición";
            }
            else // no tiene items rss anteriores en bd
            {
                MyLogger4Net.Logger.Debug("No exiten items en BD para la Fuente seleccionada");
                MyLogger4Net.Logger.Debug("Se asignaron items de la fuente por defecto");
                _Fuente.Items.AddRange(new ControladorFuentes().ItemsFuenteTexto(1, null, null).OrderByDescending(f => f.Fecha));
                msg = "Se asignaron items de la fuente por defecto";
            }

            iItemBindingSource.DataSource = _Fuente.Items;

            new VentanaEmergente(msg, VentanaEmergente.TipoMensaje.Informacion).ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ControlFecha();
        }

        //btn_peticionRss
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                _Fuente = iFuentes.ElementAt(cbx_Fuente.SelectedIndex);
                txbTipoFuente.Text = _Fuente.GetType().Name;

                if (txbTipoFuente.Text == "FuenteRSS")
                {
                    IRssReader mRssReader = new RawXmlRssReader();
                    var Fuente = (FuenteRSS)_Fuente;
                    var items = mRssReader.Read(Fuente.URL).ToList();
                    MyLogger4Net.Logger.Debug("Petición de Fuente RSS: " + Fuente.URL);
                    if (items.Count > 0)
                    {
                        iItemBindingSource.DataSource = items.ToList();
                        MyLogger4Net.Logger.Debug("Actualizando Items Rss en BD");
                        new ControladorFuentes().ActualizarItemsRss(items, _Fuente.FuenteId);
                        new VentanaEmergente("Solicitud RSS exitosa", VentanaEmergente.TipoMensaje.Exito).ShowDialog();
                    }
                    else
                    {
                        new VentanaEmergente("No se obtuvieron items en la solicitud RSS", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
                        RssSinItems(Fuente);
                    }
                }

                iItemBindingSource.ResetBindings(false);
            }
            catch (Exception)
            {
                new VentanaEmergente("No se ha podido establecer conexión a RSS", VentanaEmergente.TipoMensaje.Alerta).ShowDialog();
                RssSinItems((FuenteRSS)iFuentes.ElementAt(cbx_Fuente.SelectedIndex));
            }
        }
    }
}