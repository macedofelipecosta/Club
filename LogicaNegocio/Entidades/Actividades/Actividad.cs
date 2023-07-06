using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.ValueObject;

namespace LogicaNegocio.Entidades.Actividades
{
    public class Actividad
    {
        public int Id { get; set; }
        public Nombre Nombre { get; set; }
        public int HorarioId { get; set; }
        public int ProfesorId { get; set; }
        public int SalaId { get; set; }

    }
}
