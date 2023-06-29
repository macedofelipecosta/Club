using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mantenimientos
{
    public class GetAllMantenimientoLAException : Exception
    {
        public GetAllMantenimientoLAException()
        {
        }

        public GetAllMantenimientoLAException(string? message) : base(message)
        {
        }

        public GetAllMantenimientoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllMantenimientoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
