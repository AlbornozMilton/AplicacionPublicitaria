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
		public string Texto { get; set; }
		public string Detalles { get; set; }
    }

	public enum TipoFuente
	{
		RSS,
		TextoFijo
	}
}
