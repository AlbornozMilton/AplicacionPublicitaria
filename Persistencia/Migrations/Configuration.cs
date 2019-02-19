namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Persistencia.DAL.EntityFramework.PublicidadContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Persistencia.DAL.EntityFramework.PublicidadContext context)
        {

        }
    }
}
