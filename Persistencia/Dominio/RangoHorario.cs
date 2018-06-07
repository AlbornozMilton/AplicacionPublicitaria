using System;

namespace Persistencia.Dominio
{
    public class RangoHorario: IComparable<RangoHorario>
    {
        public int RangoHorarioId { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public RangoFecha RangoFecha { get; set; }

		public int CompareTo(RangoHorario other)
		{
			return this.HoraInicio.CompareTo(other.HoraInicio) + this.HoraFin.CompareTo(other.HoraFin); 
		}
	}
}
