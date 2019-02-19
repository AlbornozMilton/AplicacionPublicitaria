using System;
using System.Collections.Generic;
using Persistencia.DAL.EntityFramework;
using Dominio.Modelos;
using AutoMapper;

namespace Dominio.Controladores
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
		public void AgregarCampania(string pNombre, int pIntTiempo, DateTime pFechaDesde, DateTime pFechaHasta, string pDias, List<RangoHorario> pHorarios, List<Imagen> pImagenes)
		{
			RangoFecha pRangoFecha = new RangoFecha(pFechaDesde, pFechaHasta, pDias, pHorarios);
			var MapCamp = Mapper.Map<Campania, Persistencia.Dominio.Campania>(new Campania(pNombre, pIntTiempo, pRangoFecha, pImagenes));
			iUOfW.RepositorioCampania.Add(MapCamp);
			iUOfW.Complete();
		}

        public void ModificarCampania(int campViejaId, string pNombre, int pIntTiempo, DateTime pFechaDesde, DateTime pFechaHasta, string pDias, List<RangoHorario> pHorarios, List<Imagen> pImagenes)
        {
            EliminarCampania(campViejaId);
            AgregarCampania(pNombre, pIntTiempo, pFechaDesde, pFechaHasta, pDias, pHorarios, pImagenes);
        }

        public void EliminarCampania(int pIdCampania)
        { 
			iUOfW.RepositorioCampania.EliminarCampania(pIdCampania);
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
			Campania campania = Mapper.Map<Persistencia.Dominio.Campania, Campania>(campaniaPers);
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
			int i = 0;
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
			string listaDias = DateTime.Today.DayOfWeek.ToString();
			List<RangoHorario> listaHorarios = new List<RangoHorario>();
			listaHorarios.Add(new RangoHorario(pHoraInicio, pHoraInicio.Add(new TimeSpan(00, 01, 00))));
			return new Campania("Default", 60, new RangoFecha(DateTime.Today.Date, DateTime.Today.Date, DateTime.Today.DayOfWeek.ToString(), listaHorarios), null);
		}

		/// <summary>
		/// Devuleve la campaña que corresponde mostrar luego de la actual
		/// </summary>
		/// <returns></returns>
		public Campania ObtenerCampaniaSiguiente(List<Campania> pLista, TimeSpan pHoraFin)
		{
			Campania campaniaSiguiente = null;
			int i = 0;
			while (campaniaSiguiente == null && i < pLista.Count)
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
				if ((pHoraDesde >= rangHor.HoraInicio && pHoraDesde < rangHor.HoraFin) || (pHoraHasta <= rangHor.HoraFin && pHoraHasta > rangHor.HoraInicio))
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

		public List<Campania> ObtenerCampaniasFiltradas(Dictionary<Type, object> pFiltros)
		{
			if (pFiltros.ContainsKey(typeof(RangoFecha)))
			{
				pFiltros.Add(typeof(Persistencia.Dominio.RangoFecha),
							 Mapper.Map<RangoFecha, Persistencia.Dominio.RangoFecha>
							 ((RangoFecha)pFiltros[typeof(RangoFecha)]));
				pFiltros.Remove(typeof(RangoFecha));
			}
			IEnumerable<Persistencia.Dominio.Campania> listaCampFiltradas = iUOfW.RepositorioCampania.GetFiltradas(pFiltros);
			List<Campania> listaCampanias = Mapper.Map<IEnumerable<Persistencia.Dominio.Campania>, List<Campania>>(listaCampFiltradas);
			return listaCampanias;
		}

		public void ControlCamposObligatorios(string pNombre, int pDias, int pHorarios, int pImagenes, decimal pIntTiempo)
		{
			// no es necesario los else -  cuando sucede una excepcion, corta el flujo y lanza la excepcion
			if (pNombre == "")
				throw new Exception("Se debe ingresar un Nombre para la campaña");
			if (pDias == 0)
				throw new Exception("Debe seleccionar los dias");
			if (pHorarios == 0)
				throw new Exception("Debe ingresar como mínimo un rango horario");
			if (pImagenes == 0)
				throw new Exception("Se deben insertar las imagenes a mostrar");
			if (pIntTiempo == 0)
				throw new Exception("Debe seleccionar un intervalo de tiempo");
		}

        /// <summary>
        /// Actualiza las Campanias que tienen intersección con el rango de fechas elegido para usar como control.
        /// </summary>
        /// 
        public void ActualizarCampaniasEnRangoFecha(DateTime pFechaDesde, DateTime pFechaHasta, CampaniaRangoFecha pCampaniaRangoFecha)
        {
            List<Campania> lCampanias = new List<Campania>();

            foreach (var item in iUOfW.RepositorioCampania.GetCampaniasEntreFechas(pFechaDesde, pFechaHasta))
            {
                lCampanias.Add(Mapper.Map<Persistencia.Dominio.Campania, Campania>(item));
            }

            pCampaniaRangoFecha.ActualizarCampanias(lCampanias);
        }
    }
}
