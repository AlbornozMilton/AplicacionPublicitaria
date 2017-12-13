using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Dia
    {
        private DateTime iDia;
        private List<RangoHorario> iHorarios;

        //CONSTRUCTOR
        public Dia(DateTime pDia)
        {
            this.iDia = pDia.Date;
        }

        //PROPIEDADES
        public DateTime GetDia
        {
            get { return this.iDia.Date; }
            //VER SI SE PUEDE DEVOLVER EL NOMBRE DEL DIA EJ: MIERCOLES
            // es mejor devolver un string en formato fecha??
        }
        //METODOS -------------------------------------------
        public void AgregarHorario(TimeSpan pHoraInicio, int pDuracion)
        {
            // chequear que no se ingrese un horario que se superponga 
            // con otro tanto del mismo u otro banner o campaña para el mismo dia
            // el mismo DIA es igual para TODOS , es como una clave primaria
            // tener un DIA en memoria para que se carguen los horarios en el dia y utilizarla para operar ¿?

            this.iHorarios.Add( new RangoHorario(1,pHoraInicio,pDuracion));
            //tener en cuenta codigo de horario
        }

        //Sobrecargar metodo ToString???
    }
}
