using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	class TextoFijo : Fuente
	{
		public TextoFijo()
		{

		}

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