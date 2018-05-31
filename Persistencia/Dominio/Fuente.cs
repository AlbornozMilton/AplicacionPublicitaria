using System.Collections.Generic;

namespace Persistencia.Dominio
{
	public class Fuente
	{
		public int FuenteId { get; set; }

		public string NombreFuente { get; set; }

		public List<Item> Items { get; set; }
    }
}
