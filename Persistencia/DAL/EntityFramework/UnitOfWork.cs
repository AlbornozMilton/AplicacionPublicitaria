﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework
{
    public class UnitOfWork:IUnitOfWork
    {
        //atributo para utilizar un solo Contexto
        private readonly PublicidadContext iDbContext;

        //Constructor
        public UnitOfWork(PublicidadContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            this.iDbContext = pContext;
         
            //this --> por el constructor de AccountRepository
            this.RepositorioBanner = new RepositorioBanner(this.iDbContext); 
        }

        // GETTERS - IMPLEMENTACION DE IUNITOFWORK

        public IRepositorioBanner RepositorioBanner { get; private set; }

        //---implementacion de IUnitOfWork 

        /// <summary>
        /// Realiza el método SaveChanges();
        /// </summary>
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
