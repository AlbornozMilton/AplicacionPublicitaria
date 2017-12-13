using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class TextoFijo : ITextoFuente
    {
        private string iTextoPred;
        private string iNombreFuente;
        private string iDetalles;

        public TextoFijo(string pText, string pNombre, string pDetalle)
        {
            this.iTextoPred = pText;
            this.iNombreFuente = pNombre;
            this.iDetalles = pDetalle;
        }

        public string GetDetalles()
        {
            return this.iDetalles;
        }

        public string GetNombreFuente()
        {
            return this.iNombreFuente;
        }

        public string GetTexto()
        {
            return this.iTextoPred;
        }
    }
}
