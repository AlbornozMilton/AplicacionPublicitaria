using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class Fuente
	{
		private int iFuenteId;
		private List<IItem> iItems;
		
		public int FuenteId { get { return this.iFuenteId; }  set { this.iFuenteId = value; } }
		public List<IItem> Items { get { return this.iItems; }  set { this.iItems = value; } }

		public Fuente()
		{

		}
	}

	public enum TipoFuente
	{
		RSS,
		TextoFijo
	}
}
