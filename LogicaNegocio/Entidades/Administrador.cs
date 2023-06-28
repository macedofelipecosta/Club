using LogicaNegocio.ValueObject;

namespace LogicaNegocio.Entidades
{
    public class Administrador
    {
        public int Id { get; set; }
        public Nombre Name { get; set; }
        public Email Email { get; set; }
        public Guid Identificador { get; private set; }

        public Administrador()
        {
            Identificador = Guid.NewGuid();
        }


    }
}
