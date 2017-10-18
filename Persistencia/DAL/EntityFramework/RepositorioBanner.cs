using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework
{
    class RepositorioBanner:Repositorio<Banner,PublicacionContext>, IRepositorioBanner
    {

    }
}
