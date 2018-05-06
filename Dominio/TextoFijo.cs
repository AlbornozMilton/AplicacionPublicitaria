using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class TextoFijo : Fuente, IFuente
	{
		private string iNombreFuente;

		public TextoFijo()
		{

		}
		/// <summary>
		/// Utilizado para AFM Fuentes
		/// </summary>
		public TextoFijo(string pNombreFuente)
		{
			iNombreFuente = pNombreFuente;
		}

		public string NombreFuente { get { return this.iNombreFuente; } private set { this.iNombreFuente = value; } }
	}
}