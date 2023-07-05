using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.ValueObject;

namespace WebApi.DTOs
{
    public class PersonalDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Domicilio { get; set; }
        public string Contacto { get; set; }
        public int Horario { get; set; }
        public string Profesion { get; set; }

    }
}
