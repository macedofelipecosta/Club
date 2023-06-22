using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Socio
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Edad { get; }
        public Mutualista Mutualista { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }

        public Socio()
        {
            Edad = Int32.Parse(DateTime.Now.ToShortDateString())- Int32.Parse(Nacimiento.ToShortDateString());
        }
    }

}
