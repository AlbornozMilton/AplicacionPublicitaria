using System.Collections.Generic;

namespace Persistencia.Dominio
{
	public interface IFuente //no se usa
	{
		int FuenteId { get; set; }

		string NombreFuente { get; set; }

		List<Item> Items { get; set; }
	}
}
