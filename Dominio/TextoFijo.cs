using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class TextoFijo : Fuente
	{
		public TextoFijo()
		{

		}

		/// <summary>
		/// Utilizado para AFM Fuentes
		/// </summary>
		public TextoFijo(string pNombreFuente) : base(pNombreFuente, TipoFuente.TextoFijo)
		{

		}

		/// <summary>
		/// Utilizado para Capturar Items en Pant. Operativa
		/// </summary>
		public TextoFijo(string pNombreFuente, List<IItem> pItems) :base(pNombreFuente,TipoFuente.TextoFijo)
		{
			base.Items = pItems;
		}

		public void AgregarItem(string pTitulo,string pTexto, DateTime pFecha)
		{
			base.Items.Add(new ItemGenerico(pTitulo, pTexto, pFecha));
		}
	}
}