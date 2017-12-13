using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRSS: Fuente
    {
        private string iNombreFuente;

        //obtener pTexto desde el RSS
        public FuenteRSS(string pTexto, string pNombreFuente) : base(pTexto)
        {
            this.iNombreFuente = pNombreFuente;
        }
    }
}
