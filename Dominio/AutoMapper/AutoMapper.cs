using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using pers = Persistencia.Dominio;

namespace Dominio.AutoMapper
{
    class AutoMapper
    {
        public static void Mapear()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Campania, pers.Campania>().ReverseMap();

                //cfg.CreateMap<, pers.Domicilio>().ReverseMap();

                //cfg.CreateMap<Ciudad, pers.Ciudad>().ReverseMap();
            });
        }
    }
}
