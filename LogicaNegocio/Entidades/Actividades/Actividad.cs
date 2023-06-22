using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaNegocio.Entidades.Actividades
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Horario Horario { get; set; }
        public Profesor Profesor { get; set; }
        public Sala Sala { get; set; }

    }
}
