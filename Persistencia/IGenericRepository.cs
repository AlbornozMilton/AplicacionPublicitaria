using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    interface IGenericRepository<TEntity> where TEntity: class
    {
        void Create(TEntity pEntity);
        void Delete(TEntity pEntity);
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();
    }
}
