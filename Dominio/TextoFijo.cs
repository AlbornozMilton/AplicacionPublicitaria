using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	class TextoFijo : Fuente
	{
		public TextoFijo(string pNombreFuente) :base(pNombreFuente,TipoFuente.TextoFijo)
		{
		}

		public void AgregarItem(string pTitulo,string pTexto, DateTime pFecha)
		{
			base.Items.Add(new ItemGenerico(pTitulo, pTexto, pFecha));
		}
	}
}