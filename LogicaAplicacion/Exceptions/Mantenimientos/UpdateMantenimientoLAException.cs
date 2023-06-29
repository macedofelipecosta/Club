using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mantenimientos
{
    public class UpdateMantenimientoLAException : Exception
    {
        public UpdateMantenimientoLAException()
        {
        }

        public UpdateMantenimientoLAException(string? message) : base(message)
        {
        }

        public UpdateMantenimientoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateMantenimientoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
