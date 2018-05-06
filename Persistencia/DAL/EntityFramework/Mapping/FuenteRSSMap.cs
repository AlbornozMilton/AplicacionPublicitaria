using System.Data.Entity.ModelConfiguration;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class FuenteRSSMap: EntityTypeConfiguration<FuenteRSS>
    {
		public FuenteRSSMap()
		{
			this.Property(f => f.URL)
				.IsRequired();
		}
    }
}
