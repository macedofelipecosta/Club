using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Socios
{
    public class DeleteSocioLAException : Exception
    {
        public DeleteSocioLAException()
        {
        }

        public DeleteSocioLAException(string? message) : base(message)
        {
        }

        public DeleteSocioLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteSocioLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
