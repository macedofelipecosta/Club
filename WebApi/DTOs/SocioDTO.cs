using LogicaNegocio.Entidades;
using LogicaNegocio.ValueObject;

namespace WebApi.DTOs
{
    public class SocioDTO
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Edad { get; private set; }
        public string Mutualista { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public DateTime Registro { get; set; }
        public string Observaciones { get; set; }
    }
}
