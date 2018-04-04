using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using pers = Persistencia.Dominio;

namespace Dominio.AutoMapper
{
    public class AutoMapper
    {
        public static void Mapear()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Campania, pers.Campania>()
                .ForMember(dest => dest.Imagenes, opt => opt.MapFrom(src => src.Imagenes)).ReverseMap();
                cfg.CreateMap<Imagen, pers.Imagen>().ReverseMap();
                cfg.CreateMap<RangoFecha, pers.RangoFecha>().ReverseMap();
                cfg.CreateMap<RangoHorario, pers.RangoHorario>().ReverseMap();


                //cfg.CreateMap<, pers.Domicilio>().ReverseMap();

                //cfg.CreateMap<Ciudad, pers.Ciudad>().ReverseMap();
            });
        }
    }
}
