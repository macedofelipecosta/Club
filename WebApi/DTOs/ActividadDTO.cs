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
        public int HorarioId { get; set; }
        public string ProfesorId { get; set; }
        public string SalaId { get; set; }

    }
}
