using Persistencia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class RangoFechaMap : EntityTypeConfiguration<RangoFecha>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de RangoFecha.
        /// </summary>
        public RangoFechaMap()
        {
            this.Property(r => r.RangoFechaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(r => r.FechaInicio)
                .IsRequired();

			this.Property(r => r.Dias)
				 .IsRequired();

			this.Property(r => r.FechaFin)
                 .IsRequired();

            this.HasMany<RangoHorario>(RF => RF.Horarios)
                .WithRequired(RH => RH.RangoFecha)
                .Map(map => map.MapKey("RangoFechaId"))
                .WillCascadeOnDelete();

            //this.HasOptional(pCamp => pCamp.Campania)
            //    .WithRequired(r => r.RangoFecha)
            //    .Map(pMapping => pMapping.MapKey("RangoFechaId"))
            //    .WillCascadeOnDelete();
        }
    }
}
