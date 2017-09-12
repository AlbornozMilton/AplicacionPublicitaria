using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Clases;

namespace Persistencia.Mappings
{
    /// <summary>
    /// Configuraciones correspondientes a los atributos de Imagen
    /// </summary>
    class ImagenMap :EntityTypeConfiguration<Imagen>
    {
        public ImagenMap()
        {
            this.Property(I => I.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(I => I.Nombre)
                .IsRequired();

            this.Property(I => I.NroSec)
                .IsRequired();

            this.Property(I => I.Tiempo)
                .IsRequired();

            //Establece una relacion de muchos a 1 con Campania. FK: 
            this.HasRequired(I => I.Campania); 
        }
    }
}
