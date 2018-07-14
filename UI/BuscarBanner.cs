using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class BuscarBanner : Form
	{
		private static readonly log4net.ILog Loger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		private List<Banner> iResult = new List<Banner>();
		public Banner BanSelected;

		public BuscarBanner()
		{
			Loger.Info("Buscar Banner");
			InitializeComponent();
		}

		private void BuscarBanner_Load(object sender, EventArgs e)
		{
			dtp_FechaHasta.Value = dtp_FechaDesde.Value.AddMonths(1);
		}

		private void btn_Filtrar_Click(object sender, EventArgs e)
		{
			Loger.Debug("Filtrando búsqueda");
			btn_Filtrar.BorderStyle = BorderStyle.Fixed3D;
			Cursor = Cursors.WaitCursor;

			if (TB_Nombre.Text == "")
				TB_Nombre.Text = null;

			Loger.Debug("Obteniendo resultado");
			iResult = new ControladorBanner().BuscarBanner(TB_Nombre.Text, dtp_FechaDesde.Value, dtp_FechaHasta.Value);

			Loger.Debug("Cantidad de resultado: " + iResult.Count);
			dataGridBanner.Rows.Clear();
			foreach (Banner item in iResult)
			{
				dataGridBanner.Rows.Add(item.BannerId, item.Nombre, item.Fuente.Descripcion,
					item.RangoFecha.FechaInicio.Date.ToString("d") + " - " + item.RangoFecha.FechaFin.Date.ToString("d"));
			}

			btn_Filtrar.BorderStyle = BorderStyle.None;
			Cursor = Cursors.Default;
			dataGridBanner.Focus();
		}

		private void btn_Filtrar_MouseHover(object sender, EventArgs e)
		{
			btn_Filtrar.BorderStyle = BorderStyle.FixedSingle;
		}

		private void btn_Filtrar_MouseLeave(object sender, EventArgs e)
		{
			btn_Filtrar.BorderStyle = BorderStyle.None;
		}

		private void dataGridBanner_SelectionChanged(object sender, EventArgs e)
		{
			if (iResult.Count > 0)
			{
				Loger.Debug("Cambio de selección de banner");
				var banner = iResult.Find(b => b.BannerId == Convert.ToInt32((dataGridBanner.CurrentRow.Cells[0].Value)));
				Loger.Debug("Rellenando campos");
				lbl_Dias.Text = banner.RangoFecha.Dias.ToUpper().Replace('-', ' ');
				rangoHorarioBindingSource.DataSource = banner.RangoFecha.Horarios;
			}
		}

		private void lbl_Min_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void lbl_X_Click(object sender, EventArgs e)
		{
			Loger.Info("Cancelar");
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btn_Cancelar_Click(object sender, EventArgs e)
		{
			Loger.Info("Cancelar");
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btn_Aceptar_Click(object sender, EventArgs e)
		{
			if (dataGridBanner.CurrentRow != null)
			{
				BanSelected = iResult.Find(b => b.BannerId == Convert.ToInt32((dataGridBanner.CurrentRow.Cells[0].Value)));
				DialogResult = DialogResult.OK;
				Loger.Info("Banner Seleccionado:" + BanSelected.BannerId + " " + BanSelected.Nombre);
				Close();
			}
		}
	}
}
