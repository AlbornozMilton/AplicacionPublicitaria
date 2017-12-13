using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface ITextoFuente
    {
        string GetTexto();
        string GetNombreFuente();
        
        /// <summary>
        /// Detalles: URL, etc.
        /// </summary>
        /// <returns></returns>
        string GetDetalles();
    }
}
