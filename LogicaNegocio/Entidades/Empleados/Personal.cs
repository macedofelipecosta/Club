using LogicaNegocio.Entidades.Actividades;
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
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public Horario Horario { get; set; }
    }
}
