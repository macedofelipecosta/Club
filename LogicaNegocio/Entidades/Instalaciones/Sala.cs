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
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public IEnumerable<Equipo> Equipo { get; set; }
    }
}
