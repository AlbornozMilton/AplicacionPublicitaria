using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Dominio;

namespace Persistencia.DAL
{
    public interface IRepositorioCampania : IRepositorio<Campania>
    {
        IEnumerable<Campania> GetCampaniasParaElDia(DateTime pDia);

        IEnumerable<Campania> GetFiltradas(Dictionary<Type, object> pFiltros);

    }
}
