using System.Collections.Generic;

namespace Dominio.Interfaces
{
	public interface IFuente
	{
		int FuenteId { get; set; }
		string Descripcion { get; set; }
		List<IItem> Items { get; set; }
    }
}
