using System;
using System.Collections.Generic;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioBanner:IRepositorio<Banner>
    {
		List<Banner> BannersEnFecha(DateTime pDia);
		void AgregarBanner(string pNombre, int pFuenteId, RangoFecha pRFecha);
		List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin);
		List<Banner> BuscarBanner(string pNombre, DateTime pFechaInicio, DateTime pFechaFin);
		void EliminarBanner(int IdBanner);
		void ModificarBanner(int pIdBanner, string pNombre, int pFuenteId, RangoFecha pRFecha);
	}
}
