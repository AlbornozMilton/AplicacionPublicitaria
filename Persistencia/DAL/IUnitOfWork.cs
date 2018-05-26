using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    interface IUnitOfWork: IDisposable
    {
        void Complete();

        IRepositorioBanner RepositorioBanner { get; }
        IRepositorioCampania RepositorioCampania { get; }
        IRepositorioFuentes RepositorioFuentes { get; }

	}
}
