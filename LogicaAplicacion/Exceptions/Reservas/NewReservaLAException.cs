using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Reservas
{
    public class NewReservaLAException : Exception
    {
        public NewReservaLAException()
        {
        }

        public NewReservaLAException(string? message) : base(message)
        {
        }

        public NewReservaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewReservaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
