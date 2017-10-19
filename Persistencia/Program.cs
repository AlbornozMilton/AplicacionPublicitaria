using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;

namespace Persistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicacionContext db = new PublicacionContext();

            //Campania unaCamp = new Campania
            //{
            //    Nombre = "Campania3",
            //    Duracion = 5,
            //    CantCiclos = 1,
            //    RangoFecha = db.RangoFecha.Find(2)
            //};
            //db.Campania.Add(unaCamp);

            //RangoFecha unRangF = new RangoFecha
            //{
            //FechaInicio = new DateTime(2017, 6, 8),
            //FechaFin = new DateTime(2017, 6, 10)
            //};
            //db.RangoFecha.Add(unRangF);

            //Campania unaCamp = db.Campania.Find(2);
            //Imagen unaim = new Imagen
            //{
            //    Nombre = "IM3",
            //    NroSec = 2,
            //    Tiempo = 6,
            //    Campania = unaCamp
            //};
            //db.Imagen.Add(unaim);

            //var unaIm = db.Imagen.Include("Campania").Where(a => a.Id==1).FirstOrDefault<Imagen>();
            //Console.WriteLine("{0} {1} {2}", unaIm.Nombre, unaIm.Id, unaIm.Campania.Nombre);

            //Campania unaCamp = db.Campania.Find(1);
            //List<Imagen> lista = unaCamp.Imagenes.ToList();

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item.Nombre);
            //}

            db.Campania.Remove(db.Campania.Find(1));
            db.SaveChanges();
            Console.WriteLine("EXITO");
            Console.ReadKey();
        }
    }
}
