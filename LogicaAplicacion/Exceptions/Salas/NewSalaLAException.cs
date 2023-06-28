using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Salas
{
    public class NewSalaLAException : Exception
    {
        public NewSalaLAException()
        {
        }

        public NewSalaLAException(string? message) : base(message)
        {
        }

        public NewSalaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewSalaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
