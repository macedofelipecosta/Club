using LogicaNegocio.ValueObject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject
{
    public class Fecha
    {
        private DateTime _data;

        public DateTime Data { get { return _data; } set { _data = value; } }
    }
}
