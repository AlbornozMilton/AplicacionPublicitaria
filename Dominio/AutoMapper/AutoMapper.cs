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
				cfg.CreateMap<Campania, pers.Campania>().ReverseMap();
				//.ForMember(dest => dest.Imagenes, opt => opt.MapFrom(src => src.Imagenes)).ReverseMap();
				cfg.CreateMap<Imagen, pers.Imagen>().ReverseMap();
				cfg.CreateMap<RangoFecha, pers.RangoFecha>().ReverseMap();
				cfg.CreateMap<RangoHorario, pers.RangoHorario>().ReverseMap();
				cfg.CreateMap<Dia, pers.Dia>().ReverseMap();
				cfg.CreateMap<Banner, pers.Banner>().ReverseMap();

				//cfg.CreateMap < TextoFijo, pers.TextoFijo >().ReverseMap();
				//cfg.CreateMap<FuenteRSS, pers.FuenteRSS>().ReverseMap();
				cfg.CreateMap<IFuente, pers.FuenteRSS>().ReverseMap();
				cfg.CreateMap<IFuente, pers.TextoFijo>().ReverseMap();
				//cfg.CreateMap<IFuente, pers.IFuente>().ReverseMap();
				//cfg.CreateMap<IFuente, pers.Fuente>().ReverseMap();
				//cfg.CreateMap<IFuente, pers.TextoFijo>().ReverseMap();
				//cfg.CreateMap<IFuente, pers.FuenteRSS>().ReverseMap();
				//cfg.CreateMap<TipoFuente, pers.TipoFuente>().ReverseMap();

				cfg.CreateMap<ControladorBanner.Operacion, pers.Operacion>().ReverseMap();
				cfg.CreateMap<IItem, pers.Item>().ReverseMap();
			});
        }
    }
}
