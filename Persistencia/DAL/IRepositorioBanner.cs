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
		List<Banner> BannersDelDia(DateTime pDia);
    }
}
