using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mantenimientos
{
    public class NewMantenimientoLAException : Exception
    {
        public NewMantenimientoLAException()
        {
        }

        public NewMantenimientoLAException(string? message) : base(message)
        {
        }

        public NewMantenimientoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewMantenimientoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
