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
            //instanciar clases y relaciones <-- CREO QUE NO
            //aca va lo que queremos que se cargue en la base de datos al crearse. (DATOS FIJO DEL PROGRAMA)

            base.Seed(context);
        }
    }
}
