namespace Persistencia.Dominio
{
    public class Banner
    {
        public int BannerId { get; set; }

        public string Nombre { get; set; }

		public int RangoFechaId { get; set; }
        public RangoFecha RangoFecha { get; set; }

		public int FuenteId { get; set; }
        public Fuente Fuente { get; set; }
    }
}
