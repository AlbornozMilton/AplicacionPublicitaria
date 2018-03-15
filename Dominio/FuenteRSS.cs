using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRSS: IFuente
    {
        private string iNombreFuente;
        private string iTexto;
        private string iDetalles;

        //obtener pTexto desde el RSS
        public FuenteRSS(string pTexto, string pNombreFuente)// : base(pTexto)
        {
            this.iNombreFuente = pNombreFuente;
        }

        public string GetTexto()
        {
            return this.iTexto;
        }
        public string GetNombreFuente()
        {
            return this.iNombreFuente;
        }

        public string GetDetalles()
        {
            return this.iDetalles;
        }

    }
}
