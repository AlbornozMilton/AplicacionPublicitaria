using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Dominio
{
    public class Campania
    {
        public int CampaniaId { get; set; }

        public string Nombre { get; set; }

        public int IntervaloTiempo { get; set; }

        public List<Imagen> Imagenes { get; set; }

        public RangoFecha RangoFecha { get; set; }
    }
}
