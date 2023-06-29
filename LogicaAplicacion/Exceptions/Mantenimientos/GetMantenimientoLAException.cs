using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mantenimientos
{
    public class GetMantenimientoLAException : Exception
    {
        public GetMantenimientoLAException()
        {
        }

        public GetMantenimientoLAException(string? message) : base(message)
        {
        }

        public GetMantenimientoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetMantenimientoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
