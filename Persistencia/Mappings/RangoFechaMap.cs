using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Clases;
using System.Data.Entity.ModelConfiguration; 

namespace Persistencia.Mappings
{
    class RangoFechaMap:EntityTypeConfiguration<RangoFecha>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de RangoFecha.
        /// </summary>
        public RangoFechaMap()
        {
            this.Property(r => r.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(r => r.FechaInicio)
                .IsRequired();

            this.Property(r => r.FechaFin)
                 .IsRequired();
        }   
    }
}
