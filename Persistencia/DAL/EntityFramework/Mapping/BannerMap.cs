using System.Data.Entity.ModelConfiguration;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class BannerMap : EntityTypeConfiguration<Banner>
    {
		/// <summary>
		/// Configuraciones correspondientes a los atributos de Banner.
		/// </summary>
		public BannerMap()
		{
			this.Property(b => b.BannerId)
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			this.Property(b => b.Nombre)
				.IsRequired();

			this.Property(b => b.FuenteId)
				.IsRequired();

			this.HasRequired(b => b.RangoFecha);
		}
    }
}
