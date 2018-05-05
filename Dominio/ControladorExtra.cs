using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;

namespace Dominio
{
	public class ControladorExtra
	{
		private UnitOfWork iUOfW = new UnitOfWork(new PublicidadContext());
		private List<Banner> iBannersEnRangoFecha = new List<Banner>();
		private List<Campania> iCampaniasEnRangoFecha = new List<Campania>();

		/// <summary>
		/// Acutaliza los Banners que tienen intersección con el rango de fechas elegido para usar como control.
		/// </summary>
		public void ActualizarBannersEnRangoFecha(DateTime pFechaDesde, DateTime pFechaHasta)
		{
			//automapear
			//iBannersEnRangoFecha = iUOfW.RepositorioBanner.BannersEnRangoFecha(pFechas); con pFechaDesde.Date
		}

		/// <summary>
		/// Acutaliza las Campanias que tienen intersección con el rango de fechas elegido para usar como control.
		/// </summary>
		public void ActualizarCampaniasEnRangoFecha(DateTime pFechaDesde, DateTime pFechaHasta)
		{
			//automapear
			//iCampaniasEnRangoFecha = iUOfW.RepositorioCampanias.CampaniasEnRangoFecha(pFechas); con pFechaDesde.Date
		}

		/// <summary>
		/// Si hay intersección con el Horario y Días, lanza excepción
		/// </summary>
		public void ComprobarHorarioBanner(DateTime pHoraInicio, DateTime pHoraFin, string pDias)
		{
			foreach (Banner mBanner in iBannersEnRangoFecha)
			{
				RangoFecha auxRFecha = mBanner.RangoFecha;
				ComprobarHorario(auxRFecha, pHoraInicio, pHoraFin, pDias);
			}
		}

		/// <summary>
		/// Si hay intersección con el Horario y Días, lanza excepción
		/// </summary>
		public void ComprobarHorarioCampania(DateTime pHoraInicio, DateTime pHoraFin, string pDias)
		{
			foreach (Campania mCampania in iCampaniasEnRangoFecha)
			{
				RangoFecha auxRFecha = mCampania.RangoFecha;
				ComprobarHorario(auxRFecha, pHoraInicio, pHoraFin, pDias);
			}
		}

		private void ComprobarHorario(RangoFecha pRangoFecha, DateTime pHoraInicio, DateTime pHoraFin, string pDias)
		{
			IList<string> mdias = pRangoFecha.Dias.Split('-');

			foreach (string dia in mdias)
			{
				if (pDias.Contains(dia))
				{
					//utilizar TimeSpan
					foreach (RangoHorario horario in pRangoFecha.Horarios)
					{
						// if hay interserccion de horarios entre auxRango.Horarios y los de entrada
						throw new Exception("El Horario elegido no se ecuentra disponible"); //corta ejecucion
					}
				}
			}
		}
	}
}
