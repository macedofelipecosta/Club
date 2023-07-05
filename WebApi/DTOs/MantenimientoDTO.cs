using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.ValueObject;

namespace WebApi.DTOs
{
    public class MantenimientoDTO
    {
        public int Id { get; set; }
        public string Sala { get; set; }
        public string Equipo { get; set; }
        public string Descripcion { get; set; }
        public string Tecnico { get; set; }
        public DateTime Date { get; set; }

    }
}
