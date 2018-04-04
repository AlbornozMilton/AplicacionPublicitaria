using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioBanner:Repositorio<Banner,PublicidadContext>, IRepositorioBanner
    {
        public RepositorioBanner(PublicidadContext pContext):base(pContext)
        {

        }
    }
}
