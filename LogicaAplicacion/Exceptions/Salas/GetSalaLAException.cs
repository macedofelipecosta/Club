using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Salas
{
    public class GetSalaLAException : Exception
    {
        public GetSalaLAException()
        {
        }

        public GetSalaLAException(string? message) : base(message)
        {
        }

        public GetSalaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetSalaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
