using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades.Empleados
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
