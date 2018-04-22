using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	class TextoFijo : Fuente
	{
		private string iNombreFuente;

		public TextoFijo(string pText, string pNombre, string pDetalle)
		{
			this.iNombreFuente = pNombre;
		}

		public string Nombre
		{
			get { return this.iNombreFuente; }
			set { this.iNombreFuente = value; }
		}
	}
}