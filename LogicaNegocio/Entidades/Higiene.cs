using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Higiene
    {
        public int Id { get; set; }
        public Sala Sala { get; set; }
        public Observaciones Descripcion { get; set; }
        public Limpieza Limpieza { get; set; }
        public Fecha Date { get; set; }
    }
}
