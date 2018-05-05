using System;
using System.Collections.Generic;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioBanner:IRepositorio<Banner>
    {
		void AgregarBanner(Banner pBanner);
		List<Banner> BannersDelDia(DateTime pDia);
		List<Fuente> TodasLasFuentes();
		void ABMFuente(IFuente pFuente, Operacion pOperacion);
    }
}
