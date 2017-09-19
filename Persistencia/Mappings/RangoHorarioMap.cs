using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Clases;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.Mappings
{
    class RangoHorarioMap:EntityTypeConfiguration<RangoHorario>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de RangoHorario.
        /// </summary>
        public RangoHorarioMap()
        {
            this.Property(r => r.RangoHorarioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(r => r.HoraInicio)
                .IsRequired();

            this.Property(r => r.HoraFin)
                .IsRequired();

            this.HasRequired(h => h.RangoFecha)
                .WithMany(f => f.Horarios);
        }

    }
}
