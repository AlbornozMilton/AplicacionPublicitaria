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

		public void ActualizarBannersEnRangoFecha(DateTime pFechaDesde, DateTime pFechaHasta)
		{
			//automapear
			//iBannersEnRangoFecha = iUOfW.RepositorioBanner.BannersEnRangoFecha(pFechas); con pFechaDesde.Date
		}

		public void ActualizarCampaniasEnRangoFecha(DateTime pFechaDesde, DateTime pFechaHasta)
		{
			//automapear
			//iCampaniasEnRangoFecha = iUOfW.RepositorioCampanias.CampaniasEnRangoFecha(pFechas); con pFechaDesde.Date
		}

		public void ComprobarHorarioBanner(DateTime pHoraInicio, DateTime pHoraFin, List<DayOfWeek> pDias)
		{
			foreach (Banner mBanner in iBannersEnRangoFecha)
			{
				RangoFecha auxRFecha = mBanner.RangoFecha;
				ComprobarHorario(auxRFecha, pHoraInicio, pHoraFin, pDias);
			}
		}

		public void ComprobarHorarioCampania(DateTime pHoraInicio, DateTime pHoraFin, List<DayOfWeek> pDias)
		{
			foreach (Campania mCampania in iCampaniasEnRangoFecha)
			{
				RangoFecha auxRFecha = mCampania.RangoFecha;
				ComprobarHorario(auxRFecha, pHoraInicio, pHoraFin, pDias);
			}
		}

		private void ComprobarHorario(RangoFecha pRangoFecha, DateTime pHoraInicio, DateTime pHoraFin, List<DayOfWeek> pDias)
		{
			while (pRangoFecha.FechaInicio <= pRangoFecha.FechaFin)
			{
				if (pDias.Contains(pRangoFecha.FechaInicio.DayOfWeek)) // si hay interseccion de dias
				{
					foreach (RangoHorario horario in pRangoFecha.Horarios)
					{
						// if hay interserccion de horarios entre auxRango.Horarios. y los de entrada
						throw new Exception("El Horario elegido no se ecuentra disponible");
					}
				}
				pRangoFecha.FechaInicio.AddDays(1);
			}
		}
	}
}
