using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Reservas
{
    public class GetReservaLAException : Exception
    {
        public GetReservaLAException()
        {
        }

        public GetReservaLAException(string? message) : base(message)
        {
        }

        public GetReservaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetReservaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
