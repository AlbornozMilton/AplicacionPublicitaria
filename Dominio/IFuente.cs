using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public interface IFuente
	{
		int FuenteId { get; set; }
		string NombreFuente { get; }
		List<IItem> Items { get; set; }
    }
}
