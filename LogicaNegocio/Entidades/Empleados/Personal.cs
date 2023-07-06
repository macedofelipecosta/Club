using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades.Empleados
{
    public class Personal
    {
        public int Id { get; set; }
        public Nombre Name { get; set; }
        public Nombre Apellido { get; set; }
        public Cedula Cedula { get; set; }
        public Domicilio Domicilio { get; set; }
        public Contacto Contacto { get; set; }
        public Horario Horario { get; set; }

        public Personal()
        {
        }
    }
}
