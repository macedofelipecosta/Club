using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mantenimientos
{
    public class DeleteMantenimientoLAException : Exception
    {
        public DeleteMantenimientoLAException()
        {
        }

        public DeleteMantenimientoLAException(string? message) : base(message)
        {
        }

        public DeleteMantenimientoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteMantenimientoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
