using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class Fuente: IFuente
	{
		private int iFuenteId;
		private List<IItem> iItems;
		private string iNombre;
		
		public int FuenteId { get { return this.iFuenteId; }  set { this.iFuenteId = value; } }
		public string NombreFuente { get { return this.iNombre; }  set { this.iNombre = value; } }
		public List<IItem> Items { get { return this.iItems; }  set { this.iItems = value; } }

	}

	public enum TipoFuente
	{
		RSS,
		TextoFijo
	}
}
