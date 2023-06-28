using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Reservas
{
    public class DeleteReservaLAException : Exception
    {
        public DeleteReservaLAException()
        {
        }

        public DeleteReservaLAException(string? message) : base(message)
        {
        }

        public DeleteReservaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteReservaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
