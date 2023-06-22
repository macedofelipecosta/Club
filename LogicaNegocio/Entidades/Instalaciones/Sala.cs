using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades.Instalaciones
{
    public class Sala
    {
        public int Id { get; set; }
        public Nombre Nombre { get; set; }
        public Observaciones Descripcion { get; set;}
        public IEnumerable<Equipo> Equipo { get; set; }
    }
}
