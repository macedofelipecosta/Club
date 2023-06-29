using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Socios
{
    public class GetSocioLAException : Exception
    {
        public GetSocioLAException()
        {
        }

        public GetSocioLAException(string? message) : base(message)
        {
        }

        public GetSocioLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetSocioLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
