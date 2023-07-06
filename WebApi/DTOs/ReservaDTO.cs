using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Entidades;

namespace WebApi.DTOs
{
    public class ReservaDTO
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public int ActividadId { get; set; }
        public int SalaId { get; set; }
        public DateTime Fecha { get; set; }

    }
}
