using System.Collections.Generic;

namespace Dominio
{
	public interface IFuente
	{
		int FuenteId { get; set; }
		string Descripcion { get; }
		List<IItem> Items { get; set; }
    }
}
