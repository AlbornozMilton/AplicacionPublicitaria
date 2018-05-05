using System.Collections.Generic;

namespace Persistencia.Dominio
{
	public interface IFuente
	{
		int FuenteId { get; set; }

		string NombreFuente { get; set; }

		TipoFuente TipoFuente { get; set; }

		List<Item> Items { get; set; }
	}
}
