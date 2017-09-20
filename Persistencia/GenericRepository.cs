using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   abstract class GenericRepository<TEntity,TDbContext>:IGenericRepository<TEntity> where TEntity: class where TDbContext: PublicidadContext
        //Define las operaciones básicas que podrán utilizar cada entidad. 
    {
        protected readonly TDbContext iContext;

        //Constructor de una instancia de GenericRepository
        public GenericRepository(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            this.iContext = pContext;
        }

        //Crea una entidad en el repositorio
        public void Create(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iContext.Set<TEntity>().Add(pEntity);
        }

        //Elimina una entidad del repositorio
        public void Delete(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iContext.Set<TEntity>().Remove(pEntity); 
        }

        //Devuelve una entidad con el valor de clave dado
        public TEntity Get(int pId)

        {
            return this.iContext.Set<TEntity>().Find(pId);
        }

        //Devuelve todas las entidades
        public IEnumerable<TEntity> GetAll()
        {
            return this.iContext.Set<TEntity>().ToList();
        }

    }


    
}
