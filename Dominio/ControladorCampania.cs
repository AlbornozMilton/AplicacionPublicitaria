using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using AutoMapper;

namespace Dominio
{
    class ControladorCampania
    {
        UnitOfWork iUOfW = new UnitOfWork(new PublicidadContext ());

        public void AgregarCampania (Campania pCampania)
        {
            var MapCamp = Mapper.Map < Campania, Persistencia.Dominio.Campania>(pCampania);
            iUOfW.RepositorioCampania.Add(MapCamp);
        }

    }
}
