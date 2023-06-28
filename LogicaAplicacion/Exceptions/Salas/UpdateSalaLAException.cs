using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Salas
{
    public class UpdateSalaLAException : Exception
    {
        public UpdateSalaLAException()
        {
        }

        public UpdateSalaLAException(string? message) : base(message)
        {
        }

        public UpdateSalaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateSalaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
