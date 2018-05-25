using System.Collections.Generic;

namespace Persistencia.DAL
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        void Add(TEntity pEntity);
        void Remove(TEntity pEntity);
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();
    }
}
