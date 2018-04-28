using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Dominio
{
	public class Item
	{
		public int ItemId { get; set; }
		public string Titulo { get; set; }
		public string Texto { get; set; }
		public DateTime Fecha { get; set; }

		public int FuenteId { get; set; }
		public Fuente Fuente { get; set; }
	}
}
