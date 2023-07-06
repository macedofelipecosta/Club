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

        public string Calle { get; set; }
        public int NumeroPuerta { get; set; }
        public string Esquina_1 { get; set; }
        public string Esquina_2 { get; set; }

        public string Email { get; set; }
        public string Telefono_1 { get; set; }
        public string Telefono_2 { get; set; }

        public int HorarioId { get; set; }
        public string Profesion { get; set; }

    }
}
