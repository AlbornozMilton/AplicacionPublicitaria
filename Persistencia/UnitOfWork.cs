using Persistencia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class UnitOfWork:IUnitOfWork
    //Realiza las operaciones en la base de datos, centraliza el contexto guardando los cambios en una sola transacción
    //sin importar cuantos repositorios modificamos.
    
    {
        private readonly PublicidadContext iContext;
       
        /// Constructor de una instancia de UnitOfWork
        public UnitOfWork()
        {
            iContext = new PublicidadContext();
            this.iBannerRepository = new GenericRepository<Banner>(iContext);
            this.iCampaniaRepository = new GenericRepository<Campania, PublicidadContext>(iContext);
            this.iImagenRepository = new GenericRepository<Imagen>(context);
            this.iRangoFechaRepository = new GenericRepository<RangoFecha>(context);
            this.iRangoHorarioRepository = new GenericRepository<RangoHorario>(context);
            this.iFuenteRepository = new GenericRepository<Fuente>(context);
        }

        /// Devuelve el repositorio de Banners
        public virtual GenericRepository<Banner> BannerRepository
        {
            get { return this.iBannerRepository; }
        }

        /// Devuelve el repositorio de Campañas
        public virtual GenericRepository<Campania> CampaniaRepository
        {
            get { return this.iCampaniaRepository; }
        }

        /// Devuelve el repositorio de Imágenes
        public virtual GenericRepository<Imagen> ImagenRepository
        {
            get { return this.iImagenRepository; }
        }

        /// Devuelve el repositorio de Rangos de Fecha
        public virtual GenericRepository<RangoFecha> RangoFechaRepository
        {
            get { return this.iRangoFechaRepository; }
        }

        /// Devuelve el repositorio de Rangos de Horario
        public virtual GenericRepository<RangoHorario> RangoHorarioRepository
        {
            get { return this.iRangoHorarioRepository; }

        }

        /// Devuelve el repositorio de Fuentes
        public virtual GenericRepository<Fuente> FuenteRepository
        {
            get { return this.iFuenteRepository; }

        }
    }
}
