using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Salas
{
    public class GetAllSalaLAException : Exception
    {
        public GetAllSalaLAException()
        {
        }

        public GetAllSalaLAException(string? message) : base(message)
        {
        }

        public GetAllSalaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllSalaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
