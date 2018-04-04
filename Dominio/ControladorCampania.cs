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

        public void AgregarCampania (string pNombre, int pIntTiempo, DateTime pFechaDesde, DateTime pFechaHasta, List<string> pListDias, List<RangoHorario>pHorarios, List<Imagen> pImagenes)
        {
            RangoFecha pRangoFecha = new RangoFecha(pFechaDesde, pFechaHasta, pListDias,pHorarios);
            var MapCamp = Mapper.Map < Campania, Persistencia.Dominio.Campania>(new Campania(pNombre,pIntTiempo,pRangoFecha,pImagenes));
            iUOfW.RepositorioCampania.Add(MapCamp);
            iUOfW.Complete();
        }

        public Campania ObtenerCampania(int pId)
        {
            Persistencia.Dominio.Campania campaniaPers = iUOfW.RepositorioCampania.Get(pId);
            Campania campania = Mapper.Map<Persistencia.Dominio.Campania, Campania> (campaniaPers);
            return campania;
        }
    }   
}
