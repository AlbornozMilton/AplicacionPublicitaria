using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRSS: ITextoFuente
    {
        private string iURL;
        private string iNombreFuente;
        private string iDescripcion;
        private string iTexto;

        //obtener pTexto desde el RSS
        public FuenteRSS(string pTexto, string pNombreFuente)
        {
            this.iNombreFuente = pNombreFuente;
            this.iTexto = pTexto;
        }

        string ITextoFuente.GetDetalles()
        {
            return this.iDescripcion;
        }

        string ITextoFuente.GetNombreFuente()
        {
            return this.iNombreFuente;
        }

        string ITextoFuente.GetTexto()
        {
            return this.iTexto;
        }
    }
}
