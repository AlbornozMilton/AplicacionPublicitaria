using System.Collections.Generic;

namespace Dominio
{
	public interface IFuente
	{
		int FuenteId { get; set; }
		string NombreFuente { get; }
		List<IItem> Items { get; set; }
    }
}
