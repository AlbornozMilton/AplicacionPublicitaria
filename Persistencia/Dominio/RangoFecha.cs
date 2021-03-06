﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Dominio
{
    public class RangoFecha
    {
        public int RangoFechaId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

		public virtual  string Dias { get; set; }

		public virtual List<RangoHorario> Horarios { get; set; }
	}
}
