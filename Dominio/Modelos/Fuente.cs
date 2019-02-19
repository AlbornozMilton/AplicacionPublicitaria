using System.Collections.Generic;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
	public class Fuente: IFuente
	{
		private int iFuenteId;
		private List<IItem> iItems;
		private string iDecripcion;
		
		public int FuenteId { get { return this.iFuenteId; }  set { this.iFuenteId = value; } }
		public string Descripcion { get { return this.iDecripcion; }  set { this.iDecripcion = value; } }
		public List<IItem> Items { get { return this.iItems; }  set { this.iItems = value; } }

	}

	public enum TipoFuente
	{
		RSS,
		TextoFijo
	}
}
