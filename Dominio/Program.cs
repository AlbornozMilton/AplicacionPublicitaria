using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Program
    {
        static void Main(string[] args)
        {
            FuenteRSS lFuenteRSS = new FuenteRSS("Mañana a las 9am", "Barrio UTN");
            TextoFijo lTextoFijo = new TextoFijo();

            Console.WriteLine(lFuenteRSS.Texto + " " + lFuenteRSS.NombreFuente);
            Console.WriteLine(lTextoFijo.Texto);

            /*
            RangoFecha lRangoFecha = new RangoFecha(new DateTime(2017, 8, 22, 1,2,5), new DateTime(2017, 8, 25,14, 14, 24));

            Console.WriteLine(lRangoFecha.FechaString(lRangoFecha.FechaInicio) + " " + lRangoFecha.FechaString(lRangoFecha.FechaFin));
            Console.WriteLine(lRangoFecha.HoraFechaString(lRangoFecha.FechaInicio) + " " + lRangoFecha.HoraFechaString(lRangoFecha.FechaFin));

            Console.WriteLine( new DateTime(2017, 8, 22, 1, 2, 5) );

            Console.WriteLine(  lRangoFecha.HoraFechaString(new DateTime(2017, 8, 22, 1, 2, 5)) );
            */

            Console.WriteLine();
            Console.WriteLine("------------------------------TIME-SPAN----------------------------------------");

            RangoHorario lHorario = new RangoHorario(1,new TimeSpan(12,0,0),15);
            Console.WriteLine("RangoHorario lHorario = new RangoHorario(1,new TimeSpan(12,0,0),15);");
            Console.WriteLine("Codigo: {0} --- Duracion: {1} ---- HoraInicio: {2} --- HoraFin: {3}",lHorario.CodRangoHora,lHorario.Duracion,lHorario.HoraInicio,lHorario.HoraFin);
            Console.WriteLine("Ticks (unidad mas pequeña de tiempo (100 nanosegundos)): {0} ",lHorario.HoraFin.Ticks);
            Console.WriteLine("TotalDays: {0} ",lHorario.HoraFin.TotalDays);
            Console.WriteLine("TotalHours: {0} ",lHorario.HoraFin.TotalHours);
            Console.WriteLine("Duracion(): {0} ", lHorario.HoraFin.Duration());
            Console.WriteLine("lHorario.HoraInicio.CompareTo(lHorario.HoraFin): {0}", lHorario.HoraInicio.CompareTo(lHorario.HoraFin));
            Console.WriteLine("lHorario.HoraInicio.CompareTo(lHorario.HoraFin): {0}", lHorario.HoraInicio.Equals(lHorario.HoraFin));
            Console.WriteLine("lHorario.HoraInicio.CompareTo(lHorario.HoraInicio): {0}", lHorario.HoraInicio.CompareTo(lHorario.HoraInicio));
            Console.WriteLine("lHorario.HoraInicio.CompareTo(lHorario.HoraInicio): {0}", lHorario.HoraInicio.Equals(lHorario.HoraInicio));
            Console.WriteLine("lHorario.HoraInicio.CompareTo(DateTime.Now) - no devuelve excepcion: {0}", lHorario.HoraInicio.Equals(DateTime.Now));
            Console.WriteLine("(int)lHorario.HoraInicio.TotalMinutes - DownCasting - retorna int: {0}", (int)lHorario.HoraInicio.TotalMinutes);
            Console.WriteLine("lHorario.HoraInicio.TotalMinutes - retorna double : {0}", lHorario.HoraInicio.TotalMinutes);

            Console.WriteLine();
            Console.WriteLine("FromDays(215) - nuevo TimeSpan basado en 215 dias: {0} ", TimeSpan.FromDays(215));
            Console.WriteLine("FromDays(215) - TotalHours: {0} ", TimeSpan.FromDays(215).TotalHours);
            Console.WriteLine("FromDays(215) - Hour: {0} ", TimeSpan.FromDays(215).Hours);
            Console.WriteLine("FromDays(215) - Duracion(): {0} ", TimeSpan.FromDays(215).Duration());
            Console.WriteLine("TimeSpan.Zero - representacion nula de TimeSpan: {0} ", TimeSpan.Zero);
            Console.WriteLine("----------------------------------------------------------------------");


            Console.ReadKey();
        }
    }
}
