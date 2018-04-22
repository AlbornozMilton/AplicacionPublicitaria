using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRSS: IFuente
    {
		private string iURL;
		private string iDescripcion;

        public FuenteRSS()
        {
        }

		public string URL { get { return this.iURL; } set { this.iURL = value; } }

		public string Descripcion { get { return this.iDescripcion; } set { this.iDescripcion = value; } }
	}
}
