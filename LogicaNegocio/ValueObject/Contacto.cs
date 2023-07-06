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
        private Telefono? _telefono2;


        public Email Email { get { return _email; } private set { _email = value; } }
        public Telefono Telefono1 { get { return _telefono1; } private set {  _telefono1 = value; } }
        public Telefono Telefono2 { get { return _telefono2;} private set { _telefono2 = value; } }

        public Contacto(Email email, Telefono telefono1, Telefono telefono2)
        {
            Email = email;
            Telefono1 = telefono1;
            Telefono2 = telefono2;
        }
    }
}
