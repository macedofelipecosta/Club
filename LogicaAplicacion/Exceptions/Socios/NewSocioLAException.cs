using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Socios
{
    public class NewSocioLAException : Exception
    {
        public NewSocioLAException()
        {
        }

        public NewSocioLAException(string? message) : base(message)
        {
        }

        public NewSocioLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewSocioLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
