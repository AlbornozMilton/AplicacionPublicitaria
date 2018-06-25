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
				cfg.CreateMap<Banner, pers.Banner>().ReverseMap();

				cfg.CreateMap<IFuente, pers.FuenteRSS>().ReverseMap();
				cfg.CreateMap<IFuente, pers.TextoFijo>().ReverseMap();
				cfg.CreateMap<Fuente, pers.FuenteRSS>().ReverseMap();
				cfg.CreateMap<Fuente, pers.TextoFijo>().ReverseMap();
				cfg.CreateMap<TextoFijo, pers.TextoFijo>().ReverseMap();
				cfg.CreateMap<FuenteRSS, pers.FuenteRSS>().ReverseMap();

				cfg.CreateMap<ControladorFuentes.Operacion, pers.Operacion>().ReverseMap();

				cfg.CreateMap<IItem, pers.Item>().ReverseMap();
				cfg.CreateMap <pers.Item, ItemGenerico> ().ReverseMap();
				//cfg.CreateMap<pers.Item, RSS.RssItem>().RevekrseMap();
				cfg.CreateMap<pers.Item, RSS.RssItem>().ReverseMap();
				//ForMember(x => x.fi, x => x.MapFrom(y => y.Pais.Nombre));
			});
        }
    }
}
