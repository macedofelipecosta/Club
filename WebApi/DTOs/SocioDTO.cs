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
        public string MutualistaId { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Esquina_1 { get; set; }
        public string Esquina_2 { get; set; }
        public string Email { get; set; }
        public string Telefono_1 { get; set; }
        public string Telefono_2 { get; set; }
        public DateTime Registro { get; set; }
        public string Observaciones { get; set; }
    }
}
