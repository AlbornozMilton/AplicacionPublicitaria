using Persistencia.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.DAL.EntityFramework.Mapping
{
	class ItemRssMap: EntityTypeConfiguration<ItemRss>
	{
		public ItemRssMap()
		{
			this.Property(i => i.Url)
				.IsRequired();
		}
	}
}
