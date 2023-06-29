using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject
{
    public class Domicilio
    {
        private string _calle;
        private int _nro;
        private string _esquina1;
        private string _esquina2;

        

        public string Calle { get { return _calle; } set { _calle = value; } }
        public int Nro { get { return _nro; } set { _nro = value; } }
        public string Esquina1 { get { return _esquina1; } set { _esquina1 = value; } }
        public string Esquina2 { get { return _esquina2; } set { _esquina2 = value; } }
    }
}
