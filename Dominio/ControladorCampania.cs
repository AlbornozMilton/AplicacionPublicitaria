﻿using System;
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
            IEnumerable<Persistencia.Dominio.Campania> listaEnum = iUOfW.RepositorioCampania.GetAll();
            List<Campania> campanias = new List<Campania>();
            foreach (var camp in listaEnum)
            {
                Campania unaCampania = (Mapper.Map<Persistencia.Dominio.Campania, Campania>(camp));
                if ((((unaCampania.RangoFecha.Dias.Where(d => d.Nombre == pDia.DayOfWeek.ToString())).Count()) != 0) && (pDia.Date >= unaCampania.RangoFecha.FechaInicio.Date) && (pDia.Date <= unaCampania.RangoFecha.FechaFin.Date))
                {
                    campanias.Add(unaCampania);
                }
            }
            return campanias;
        }

        /// <summary>
        /// Devuelve la campaña que corresponde mostrar en estos momentos
        /// </summary>
        /// <returns></returns>
        public Campania ObtenerCampaniaActual(List<Campania> pLista)
        {
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

        /// <summary>
        /// Devuleve la campaña que corresponde mostrar luego de la actual
        /// </summary>
        /// <returns></returns>
        public Campania ObtenerProximaCampania(List<Campania> pLista)
        {
            return null;
        }
        //public List<Campania> CampaniasDelDia()
        //{
        //    iUOfW.RepositorioCampania.GetAllCampaniasDelDia();
        //}
    }   
}
