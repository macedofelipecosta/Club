using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Mutualista
    {
        public int Id { get; set; }
        public Nombre Name { get; set; }
        public Telefono Telefono { get; set; }
        public Emergencia Emergencia { get; set; }

        public Mutualista()
        {
        }
    }
}
