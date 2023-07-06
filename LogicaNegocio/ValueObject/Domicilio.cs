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
        private string? _esquina1;
        private string? _esquina2;

        

        public string Calle { get { return _calle; } private set { _calle = value; } }
        public int Nro { get { return _nro; } private set { _nro = value; } }
        public string Esquina1 { get { return _esquina1; } private set { _esquina1 = value; } }
        public string Esquina2 { get { return _esquina2; } private set { _esquina2 = value; } }

        public Domicilio(string calle, int nro, string esquina1, string esquina2)
        {
            Calle = calle;
            Nro = nro;
            Esquina1 = esquina1;
            Esquina2 = esquina2;
        }
    }
}
