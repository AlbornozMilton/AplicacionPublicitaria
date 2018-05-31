using Persistencia.Dominio;
using System.Data.Entity.ModelConfiguration;
namespace Persistencia.DAL.EntityFramework.Mapping
{
	class FuenteMap : EntityTypeConfiguration<Fuente>
	{
		public FuenteMap()
		{
			this.Property(pCamp => pCamp.FuenteId)
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			this.Property(pCamp => pCamp.Descripcion)
				.IsRequired();
		}
	}
}
