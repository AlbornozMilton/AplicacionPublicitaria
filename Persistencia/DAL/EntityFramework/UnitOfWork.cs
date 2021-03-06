﻿using System;

namespace Persistencia.DAL.EntityFramework
{
    public class UnitOfWork:IUnitOfWork
    {
        //atributo para utilizar un solo Contexto
        private readonly PublicidadContext iDbContext;

        //Constructor - Al construirse tambi{en instancia sus getters
        public UnitOfWork(PublicidadContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            this.iDbContext = pContext;
         
            this.RepositorioCampania = new RepositorioCampania(this.iDbContext);

			this.RepositorioBanner = new RepositorioBanner(this.iDbContext);

			this.RepositorioFuentes = new RepositorioFuentes(this.iDbContext);
        }

        // GETTERS - IMPLEMENTACION DE IUNITOFWORK

        public IRepositorioCampania RepositorioCampania { get; private set; }

        public IRepositorioBanner RepositorioBanner { get; private set; }

        public IRepositorioFuentes RepositorioFuentes { get; private set; }

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
