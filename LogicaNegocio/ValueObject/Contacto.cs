using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject
{
    public class Contacto
    {
        private Email _email;
        private Telefono _telefono1;
        private Telefono _telefono2;


        public Email Email { get { return _email; } set { _email = value; } }
        public Telefono Telefono1 { get { return this._telefono1; } set {  this._telefono1 = value; } }
        public Telefono Telefono2 { get { return this._telefono2;} set { this._telefono2 = value; } }

    }
}
