using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mutualista
{
    public class NewMutualistaLAException : Exception
    {
        public NewMutualistaLAException()
        {
        }

        public NewMutualistaLAException(string? message) : base(message)
        {
        }

        public NewMutualistaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewMutualistaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
