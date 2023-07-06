using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.ValueObject;

namespace WebApi.DTOs
{
    public class MantenimientoDTO
    {
        public int Id { get; set; }
        public string SalaId { get; set; }
        public string EquipoId { get; set; }
        public string Descripcion { get; set; }
        public string TecnicoId { get; set; }
        public DateTime Date { get; set; }

    }
}
