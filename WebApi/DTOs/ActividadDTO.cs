using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.ValueObject;

namespace WebApi.DTOs
{
    public class ActividadDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Horario { get; set; }
        public string Profesor { get; set; }
        public string Sala { get; set; }

    }
}
