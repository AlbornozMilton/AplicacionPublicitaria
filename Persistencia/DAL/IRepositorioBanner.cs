using System;
using System.Collections.Generic;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioBanner:IRepositorio<Banner>
    {
		void AgregarBanner(string pNombre, int pFuenteId, RangoFecha pRFecha);
		List<Banner> BannersDelDia(DateTime pDia);
		List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin);
	}
}
