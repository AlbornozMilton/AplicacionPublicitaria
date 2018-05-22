using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia.DAL.EntityFramework;
using AutoMapper;

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
			iBannersEnRangoFecha.Clear();
			foreach (var banner in iUOfW.RepositorioBanner.BannersEnRangoFecha(pFechaDesde.Date, pFechaHasta.Date))
			{
				iBannersEnRangoFecha.Add(Mapper.Map<Persistencia.Dominio.Banner,Banner>(banner));
			}
		}

		/// <summary>
		/// Acutaliza las Campanias que tienen intersección con el rango de fechas elegido para usar como control.
		/// </summary>
		public void ActualizarCampaniasEnRangoFecha(DateTime pFechaDesde, DateTime pFechaHasta)
		{
			//idem a ActualizarBannersEnRangoFecha
		}

		/// <summary>
		/// Si hay intersección con el Horario y Días, lanza excepción
		/// </summary>
		public void ComprobarHorarioBanner(List<RangoHorario> pHorarios, string pDias)
		{
			foreach (Banner mBanner in iBannersEnRangoFecha)
			{
				RangoFecha auxRFecha = mBanner.RangoFecha;
				foreach (RangoHorario item in pHorarios)
				{
					ComprobarHorario(auxRFecha, item.HoraInicio, item.HoraFin, pDias); 
				}
			}
		}

		/// <summary>
		/// Si hay intersección con el Horario y Días, lanza excepción
		/// </summary>
		public void ComprobarHorarioCampania(TimeSpan pHoraInicio, TimeSpan pHoraFin, string pDias)
		{
			foreach (Campania mCampania in iCampaniasEnRangoFecha)
			{
				RangoFecha auxRFecha = mCampania.RangoFecha;
				ComprobarHorario(auxRFecha, pHoraInicio, pHoraFin, pDias);
			}
		}

		public void ComprobarHorario(RangoFecha pRangoFecha, TimeSpan pHoraInicio, TimeSpan pHoraFin, string pDias)
		{
			IList<string> mdias = pRangoFecha.Dias.Split('-');

			foreach (string dia in mdias)
			{
				if (pDias.Contains(dia))
				{
					foreach (RangoHorario horario in pRangoFecha.Horarios)
					{
						if (!(horario.HoraInicio.CompareTo(pHoraInicio) > 0 && horario.HoraInicio.CompareTo(pHoraFin) > 0)
						&&
						(!(horario.HoraFin.CompareTo(pHoraInicio) < 0 && horario.HoraFin.CompareTo(pHoraFin) < 0)))
							throw new ApplicationException("Los Horarios y Días elegidos no se encuentran disponibles");
					}
				}
			}
		}
	}
}
