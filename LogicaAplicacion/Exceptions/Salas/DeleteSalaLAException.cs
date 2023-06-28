using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Salas
{
    public class DeleteSalaLAException : Exception
    {
        public DeleteSalaLAException()
        {
        }

        public DeleteSalaLAException(string? message) : base(message)
        {
        }

        public DeleteSalaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteSalaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
