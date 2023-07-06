using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades.Servicios
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public int SalaId { get; set; }
        public int EquipoId { get; set; }
        public Observaciones Descripcion { get; set; }
        public int TecnicoId { get; set; }
        public Fecha Date { get; set; }

        public Mantenimiento() { }

    }
}
