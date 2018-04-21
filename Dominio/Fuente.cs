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
		private string iNombreFuente;
		private TipoFuente iTipoFuente;
		private IList<IItem> iItems;
		
		public int FuenteId { get { return this.iFuenteId; }  set { this.iFuenteId = value; } }
		public IList<IItem> Items { get { return this.iItems; }  set { this.iItems = value; } }

		public string NombreFuente { get { return this.iNombreFuente; } set { this.iNombreFuente = value; } }
		public TipoFuente TipoFuente { get { return this.iTipoFuente; } set { this.iTipoFuente = value; } }

		public Fuente(string pNombre, TipoFuente pTipo)
		{
			iNombreFuente = pNombre;
			iTipoFuente = pTipo;
		}
	}

	public enum TipoFuente
	{
		RSS,
		TextoFijo
	}
}
