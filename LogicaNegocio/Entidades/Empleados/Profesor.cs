using LogicaNegocio.ValueObject;

namespace LogicaNegocio.Entidades.Empleados
{
    public class Profesor : Personal
    {
        public Profesion Profesion { get; set; }
    }
}
