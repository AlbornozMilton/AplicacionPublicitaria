using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clases
{
    public class Banner
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public RangoFecha RangoFecha { get; set; }

        public Fuente Fuente { get; set; }

    }
}
