﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    interface IUnitOfWork: IDisposable
    {
        void Complete();

        IRepositorioCliente RepositorioCliente { get; }
    }
}
