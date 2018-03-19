using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia.DAL.EntityFramework;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UnitOfWork UoW = new UnitOfWork(new PublicidadContext());
            UoW.Complete();
            Application.Run(new AgregarBanner());
        }
    }
}
