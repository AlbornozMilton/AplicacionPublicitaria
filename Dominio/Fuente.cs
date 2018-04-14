using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class Fuente :IFuente
	{
		private int iFuenteId;
		private TipoFuente iTipoFuente;
		private string iTexto;
		private string iDetalles;

		public int FuenteId { get { return this.iFuenteId; } set { this.iFuenteId = value; } }
		public TipoFuente TipoFuente { get { return this.iTipoFuente; } set { this.iTipoFuente = value; } }
		public string Texto { get { return this.iTexto; } set { this.iTexto = value; } }
		public string Detalles { get { return this.iDetalles; } set { this.iDetalles = value; } }
	}

	public enum TipoFuente
	{
		RSS,
		TextoFijo
	}
}
