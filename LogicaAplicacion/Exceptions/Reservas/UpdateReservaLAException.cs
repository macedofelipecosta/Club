using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Reservas
{
    public class UpdateReservaLAException : Exception
    {
        public UpdateReservaLAException()
        {
        }

        public UpdateReservaLAException(string? message) : base(message)
        {
        }

        public UpdateReservaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateReservaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
