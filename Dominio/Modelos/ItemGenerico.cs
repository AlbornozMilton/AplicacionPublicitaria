using System;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
	public class ItemGenerico:IItem
	{
		private int iItemId;
		private string iTitulo;
		private string iTexto;
		private DateTime iFechaItem;

		public ItemGenerico()
		{

		}

		public ItemGenerico(string pTitulo, string pTexto, DateTime pFecha)
		{
			iTitulo = pTitulo;
			iTexto = pTexto;
			iFechaItem = pFecha;
		}

		public int ItemId { get { return iItemId; } set { iItemId = value; } }
		public string Titulo { get { return iTitulo; } set { iTitulo = value; } }
		public string Texto { get { return iTexto; } set { iTexto = value; } }
		public DateTime Fecha { get { return iFechaItem; } set { iFechaItem = value; } }
	}
}
