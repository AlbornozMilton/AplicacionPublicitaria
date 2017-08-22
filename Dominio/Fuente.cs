using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Fuente
    {
        protected string iTexto;

        public Fuente(string pTexto)
        {
            this.iTexto = pTexto;
        }

        public string Texto { get { return this.iTexto; } }
    }
}
