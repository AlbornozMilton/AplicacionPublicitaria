using Persistencia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class CampaniaMap : EntityTypeConfiguration<Campania>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de Campania
        /// </summary>
        public CampaniaMap()
        {
            this.Property(pCamp => pCamp.CampaniaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(pCamp => pCamp.Nombre)
                .IsRequired();

            this.Property(pCamp => pCamp.Duracion)
                .IsRequired();

            //////this.Property(pCamp => pCamp.CantCiclos)
            //////    .IsRequired();

            //Establece la relacio muchos a 1 con RangoFecha.
            ////this.HasRequired(pCamp => pCamp.RangoFecha)
            ////    .WithMany(r => r.Campanias);
        }

    }
}
