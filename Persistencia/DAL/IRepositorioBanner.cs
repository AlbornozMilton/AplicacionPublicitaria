using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioBanner:IRepositorio<Banner>
    {
		void AgregarBanner(Banner pBanner);
		List<Banner> BannersDelDia(DateTime pDia);
		List<Fuente> TodasLasFuentes();
    }
}
