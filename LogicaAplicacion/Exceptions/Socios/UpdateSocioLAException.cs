using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Socios
{
    public class UpdateSocioLAException : Exception
    {
        public UpdateSocioLAException()
        {
        }

        public UpdateSocioLAException(string? message) : base(message)
        {
        }

        public UpdateSocioLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateSocioLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
