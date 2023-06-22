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
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid Identificador { get; private set; }

        public Administrador()
        {
            Identificador = Guid.NewGuid();
        }


    }
}
