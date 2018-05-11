using Persistencia.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    /// <summary>
    /// Configuraciones correspondientes a los atributos de Imagen
    /// </summary>
    class ImagenMap : EntityTypeConfiguration<Imagen>
    {
        public ImagenMap()
        {
            this.Property(I => I.ImagenId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(I => I.Nombre)
                .IsRequired();

            this.Property(I => I.NumSecuencia)
                .IsRequired();

            this.Property(I => I.Ruta)
                .IsRequired();

            //this.HasRequired<Campania>(I => I.Campania)
            //    .WithMany(C => C.Imagenes)
            //    .Map(pMapping => pMapping.MapKey("ImagenId"))
            //    .WillCascadeOnDelete();

            //////////////Establece una relacion de muchos a 1 con Campania. FK: CampaniaId 
            ////////////this.HasRequired(i => i.Campania)//establece que una imagen no se puede guardar sin una campaña asociada
            ////////////    .WithMany(c => c.Imagenes);//hace referencia que una campaña posee muchas imagenes
        }
    }
}
