using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Dominio
{
	public class Fuente
	{
		public int FuenteId { get; set; }
		public TipoFuente TipoFuente { get; set; }
		public string NombreFuente { get; set; }

		public List<Item> Items { get; set; }
    }

	public enum TipoFuente
	{
		RSS,
		TextoFijo
	}
}
