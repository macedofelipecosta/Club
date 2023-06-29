using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Socios
{
    public class GetAllSocioLAException : Exception
    {
        public GetAllSocioLAException()
        {
        }

        public GetAllSocioLAException(string? message) : base(message)
        {
        }

        public GetAllSocioLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllSocioLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
