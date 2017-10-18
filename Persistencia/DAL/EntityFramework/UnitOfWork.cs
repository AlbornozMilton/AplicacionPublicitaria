using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework
{
    class UnitOfWork:IUnitOfWork
    {
        //atributo para utilizar un solo Contexto
        private readonly PublicacionContext iDbContext;

        //Constructor
        public UnitOfWork(PublicacionContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            //asigna el contexto 
            this.iDbContext = pContext;

            //SE UTILIZA LOS GETTERS!! ¿?--------------sin atributo ??? iClientRepository???
            //SE INSTANCIA CON TODAS LAS IMPLEMENTACIONES DEFINIDAS
            this.RepositorioCliente = new RepositorioCliente(this.iDbContext); //porque el this???-->por el constructor de AccountRepository
        }

        // GETTERS - IMPLEMENTACION DE IUNITOFWORK

        public IRepositorioCliente RepositorioCliente { get; private set; }

        /// <summary>
        /// Realiza el método SaveChanges();
        /// </summary>
        //implementacion de IUnitOfWork 
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        /// <summary>
        ///Implementación de IDisposable: Define el método Dispose para liberar recursos no administrados.
        /// </summary>
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
    }
}
