using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework
{
    class DatabaseInitializationStrategy: CreateDatabaseIfNotExists<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            //instanciar clases y relaciones

            base.Seed(context);
        }
    }
}
