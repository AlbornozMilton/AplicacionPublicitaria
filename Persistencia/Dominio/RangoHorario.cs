﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Dominio
{
    public class RangoHorario
    {
        public int RangoHorarioId { get; set; }

        public DateTime HoraInicio { get; set; }

        public DateTime HoraFin { get; set; }

        public int RangoFechaId { get; set; }

        public RangoFecha RangoFecha { get; set; }
    }
}
