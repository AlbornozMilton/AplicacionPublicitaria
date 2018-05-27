using System;
using System.Collections.Generic;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioBanner:IRepositorio<Banner>
    {
		void AgregarBanner(int IdBannerMod, string pNombre, int pFuenteId, RangoFecha pRFecha);
		List<Banner> BannersDelDia(DateTime pDia);
		List<Banner> BannersEnRangoFecha(DateTime pFechaInicio, DateTime pFechaFin);
		List<Banner> BuscarBanner(string pNombre, DateTime pFechaInicio, DateTime pFechaFin);
		void EliminarBanner(int IdBanner);

	}
}
