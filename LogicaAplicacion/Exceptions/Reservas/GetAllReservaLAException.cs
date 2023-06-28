using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Reservas
{
    public class GetAllReservaLAException : Exception
    {
        public GetAllReservaLAException()
        {
        }

        public GetAllReservaLAException(string? message) : base(message)
        {
        }

        public GetAllReservaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllReservaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
