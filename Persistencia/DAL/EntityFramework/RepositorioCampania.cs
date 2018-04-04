using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioCampania : Repositorio<Campania, PublicidadContext>, IRepositorioCampania
    {
        public RepositorioCampania(PublicidadContext pContext) : base(pContext)
        {

        }
        public override Campania Get(int pIdCampania)
        {
            return iDbContext.Campania.Include("Imagenes").Include("RangoFecha").Where(c => c.CampaniaId == pIdCampania).SingleOrDefault();
        }
    }
}
