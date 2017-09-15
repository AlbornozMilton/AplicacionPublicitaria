using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Clases;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.Mappings
{
    class CampaniaMap:EntityTypeConfiguration<Campania>
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

            this.Property(pCamp => pCamp.CantCiclos)
                .IsRequired();

            //Establece la relacio muchos a 1 con RangoFecha.
            //this.HasRequired(pCamp => pCamp.RangoFecha);
        }
        
    }
}
