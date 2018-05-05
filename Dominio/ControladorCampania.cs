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
            RangoFecha pRangoFecha = new RangoFecha(pFechaDesde, pFechaHasta, /*pListDias*/"lunes",pHorarios);
            var MapCamp = Mapper.Map < Campania, Persistencia.Dominio.Campania>(new Campania(pNombre,pIntTiempo,pRangoFecha,pImagenes));
            iUOfW.RepositorioCampania.Add(MapCamp);
            iUOfW.Complete();
        }

        public void EliminarCampania(Campania pCampania)
        {
            var MapCamp = Mapper.Map<Campania, Persistencia.Dominio.Campania>(pCampania);
            iUOfW.RepositorioCampania.Remove(MapCamp);
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
            Campania campaniaActual = null;
            int i= 0;
            while (campaniaActual == null && i < pLista.Count)
            {
                foreach (var rangHor in pLista[i].RangoFecha.Horarios)
                {
                    if (((DateTime.Now.TimeOfDay.TotalMinutes) >= rangHor.HoraInicio.TotalMinutes) && (DateTime.Now.TimeOfDay.TotalMinutes <= rangHor.HoraFin.TotalMinutes))
                    {
                        var c = pLista[i];
                        campaniaActual = new Campania(c.Nombre, c.IntervaloTiempo, new RangoFecha(rangHor), c.Imagenes);
                    }
                }
                i++;
            }
            if (campaniaActual == null)
            {
                campaniaActual = GenerarCampaniaNula(DateTime.Now.TimeOfDay);
            }
            return campaniaActual;
        }

        /// <summary>
        /// Devuleve la campaña que se muestra por defecto como relleno de espacios sin publicidad
        /// </summary>
        /// <param name="pHoraInicio"></param>
        /// <returns></returns>
        public Campania GenerarCampaniaNula(TimeSpan pHoraInicio)
        {
            List<Dia> listaDias = new List<Dia>();
            listaDias.Add(new Dia(DateTime.Today.DayOfWeek.ToString()));
            List<RangoHorario> listaHorarios = new List<RangoHorario>();
            listaHorarios.Add(new RangoHorario(pHoraInicio, pHoraInicio.Add(new TimeSpan(00, 01, 00))));
            List<Imagen> listaImagenes = new List<Imagen>();
            Imagen imagenPublicidad = new Imagen("ImgDefault", "C:\\Users\\Milton\\Pictures\\Imagenes mias\\PorDefecto.gif");
            listaImagenes.Add(imagenPublicidad);
            return new Campania("Default", 60, new RangoFecha(DateTime.Today.Date, DateTime.Today.Date, /*listaDias*/"luenes" , listaHorarios),listaImagenes);
        }

        /// <summary>
        /// Devuleve la campaña que corresponde mostrar luego de la actual
        /// </summary>
        /// <returns></returns>
        public Campania ObtenerCampaniaSiguiente(List<Campania> pLista, TimeSpan pHoraFin)
        {
            Campania campaniaSiguiente = null;
            int i = 0;
            while (campaniaSiguiente == null &&  i < pLista.Count)
            {
                foreach (var rangHor in pLista[i].RangoFecha.Horarios)
                {
                    if (pHoraFin == rangHor.HoraInicio)
                    {
                        var c = pLista[i];
                        campaniaSiguiente = new Campania(c.Nombre, c.IntervaloTiempo, new RangoFecha(rangHor), c.Imagenes);
                    }
                }
                i++;
            }
            if (campaniaSiguiente == null)
            {
                campaniaSiguiente = GenerarCampaniaNula(pHoraFin);
            }
        return campaniaSiguiente;
        }

        public Boolean ControlColisionHorarios(List<RangoHorario> pHorarios, TimeSpan pHoraDesde, TimeSpan pHoraHasta)
        {
            foreach (var rangHor in pHorarios)
            {
                if ((pHoraDesde >= rangHor.HoraInicio && pHoraDesde <= rangHor.HoraFin) || (pHoraHasta <= rangHor.HoraFin && pHoraHasta > rangHor.HoraInicio))
                {
                    throw new Exception("El rango ingresado se superpone con otro ya cargado");
                }
            }
            return true;
        }

        public List<string> DiasEntreFechas(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            List<string> listaDias = new List<string>();
            TimeSpan diferencia = pFechaHasta - pFechaDesde;
            for (int i = 0; i <= (diferencia.Days); i++)
            {
                DateTime nuevaFecha = pFechaDesde.AddDays(i);
                if (!listaDias.Contains(nuevaFecha.DayOfWeek.ToString()))
                {
                    listaDias.Add(nuevaFecha.DayOfWeek.ToString());
                }
            }
            return listaDias;
        }

        public List<Campania> ObtenerTodasCampanias() //CUAL ES EL FIN DE ESTE METODO?
        {
            IEnumerable<Persistencia.Dominio.Campania> listaTodasCamp = iUOfW.RepositorioCampania.GetAll();
            List<Campania> listaCampanias = Mapper.Map<IEnumerable<Persistencia.Dominio.Campania>, List<Campania>>(listaTodasCamp);
            iUOfW.Dispose();
            return listaCampanias;
        }
        public Boolean ControlCamposObligatorios(string pNombre, int pDias, int pHorarios, int pImagenes, decimal pIntTiempo)
        {
            if (pNombre == "")
            {
                throw new Exception("Se debe ingresar un Nombre para la campaña");
            }
            else
            {
                if (pDias == 0)
                {
                    throw new Exception("Debe seleccionar los dias");
                }
                else
                {
                    if (pHorarios == 0)
                    {
                        throw new Exception("Debe ingresar como mínimo un rango horario");
                    }
                    else
                    {
                        if (pImagenes == 0)
                        {
                            throw new Exception("Se deben insertar las imagenes a mostrar");
                        }
                        else
                        {
                            if (pIntTiempo == 0)
                            {
                                throw new Exception("Debe seleccionar un intervalo de tiempo");
                            }
                        }
                    }
                }
            }
            return true;
        }
    }   
}
