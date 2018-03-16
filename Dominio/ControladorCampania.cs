using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using AutoMapper;

namespace Dominio
{
    public class ControladorCampania
    {
        UnitOfWork iUOfW = new UnitOfWork(new PublicidadContext());

        public void AgregarCampania (string pNombre, int pDuracion)
        {

            var MapCamp = Mapper.Map < Campania, Persistencia.Dominio.Campania>(new Campania(pNombre,pDuracion));
            iUOfW.RepositorioCampania.Add(MapCamp);
            iUOfW.Complete();
        }

    }
}
