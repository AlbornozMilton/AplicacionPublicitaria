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

        /// <summary>
        /// Agrega una nueva campaña a la Base de Datos
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pIntTiempo"></param>
        /// <param name="pFechaDesde"></param>
        /// <param name="pFechaHasta"></param>
        /// <param name="pListDias"></param>
        /// <param name="pHorarios"></param>
        /// <param name="pImagenes"></param>
        public void AgregarCampania (string pNombre, int pIntTiempo, DateTime pFechaDesde, DateTime pFechaHasta, List<Dia> pListDias, List<RangoHorario>pHorarios, List<Imagen> pImagenes)
        {
            RangoFecha pRangoFecha = new RangoFecha(pFechaDesde, pFechaHasta, pListDias,pHorarios);
            var MapCamp = Mapper.Map < Campania, Persistencia.Dominio.Campania>(new Campania(pNombre,pIntTiempo,pRangoFecha,pImagenes));
            iUOfW.RepositorioCampania.Add(MapCamp);
            iUOfW.Complete();
        }

        /// <summary>
        /// Devuelve una campaña a partir de un ID ingresado
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Campania ObtenerCampania(int pId)
        {
            Persistencia.Dominio.Campania campaniaPers = iUOfW.RepositorioCampania.Get(pId);
            Campania campania = Mapper.Map<Persistencia.Dominio.Campania, Campania> (campaniaPers);
            return campania;
        }

        /// <summary>
        /// Devuelve una lista de campañas correspondientes al dia que se le ingrese
        /// </summary>
        /// <param name="pDia"></param>
        /// <returns></returns>
        public List<Campania> ObtenerCampaniasParaElDia(DateTime pDia)
        {
            IEnumerable<Persistencia.Dominio.Campania> listaEnum = iUOfW.RepositorioCampania.GetCampaniasParaElDia(pDia);
            List<Campania> campanias = new List<Campania>();
            foreach (var campania in listaEnum)
            {
                Campania unaCampania = (Mapper.Map<Persistencia.Dominio.Campania, Campania>(campania));
                campanias.Add(unaCampania);
            }
            return campanias;
        }

        /// <summary>
        /// Devuelve la campaña que corresponde mostrar en estos momentos
        /// </summary>
        /// <returns></returns>
        public Campania ObtenerCampaniaActual(List<Campania> pLista)
        {
            //agregar el tema hacer una compia de la campania y vaciar la lista de horarios menos el de ahora.
            Campania campaniaActual = null;
            int indice = 0;
            //int indHorario;
            while (campaniaActual == null && indice < pLista.Count)
            {
                foreach (var rangHor in pLista[indice].RangoFecha.Horarios)
                {
                    if (((DateTime.Now.TimeOfDay.TotalMinutes) >= rangHor.HoraInicio.TotalMinutes) && (DateTime.Now.TimeOfDay.TotalMinutes <= rangHor.HoraFin.TotalMinutes))
                    {
                        campaniaActual = pLista[indice];
                    }
                }
                indice++;
            }
            return campaniaActual;
        }

        public Campania GenerarCampaniaNula(TimeSpan pHoraInicio)
        {
            List<Dia> listaDias = new List<Dia>();
            listaDias.Add(new Dia(DateTime.Today.DayOfWeek.ToString()));
            List<RangoHorario> listaHorarios = new List<RangoHorario>();
            listaHorarios.Add(new RangoHorario(pHoraInicio, pHoraInicio.Add(new TimeSpan(00, 01, 00))));
            List<Imagen> listaImagenes = new List<Imagen>();
            listaImagenes.Add(new Imagen("ImgDefault", "C:\\Users\\Milton\\Pictures\\Imagenesmias\\Presentacion.png"));
            return new Campania("Default", 60, new RangoFecha(DateTime.Today.Date, DateTime.Today.Date, listaDias , listaHorarios),listaImagenes);
        }

        /// <summary>
        /// Devuleve la campaña que corresponde mostrar luego de la actual
        /// </summary>
        /// <returns></returns>
        public Campania ObtenerCampaniaSiguiente(List<Campania> pLista, TimeSpan pHoraFin)
        {
            //agregar el tema hacer una compia de la campania y vaciar la lista de horarios menos el de ahora.
            //int indiceHorario = 0;
            //int indHorario;
            Campania campaniaSiguiente = null;
            for (int i = 0; i < pLista.Count; i++)
            {
                foreach (var rangHor in pLista[i].RangoFecha.Horarios)
                {
                    if (pHoraFin == rangHor.HoraInicio)
                    {
                        campaniaSiguiente = pLista[i];
                    }
                }
            }
            if (campaniaSiguiente == null)
            {
                campaniaSiguiente = GenerarCampaniaNula(pHoraFin);
            }
            return campaniaSiguiente;
        }
        //public List<Campania> CampaniasDelDia()
        //{
        //    iUOfW.RepositorioCampania.GetAllCampaniasDelDia();
        //}
    }   
}
