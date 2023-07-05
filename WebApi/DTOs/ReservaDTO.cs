using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Entidades;

namespace WebApi.DTOs
{
    public class ReservaDTO
    {
        public int Id { get; set; }
        public string Socio { get; set; }
        public string Actividad { get; set; }
        public string Sala { get; set; }
        public DateTime Fecha { get; set; }

    }
}
