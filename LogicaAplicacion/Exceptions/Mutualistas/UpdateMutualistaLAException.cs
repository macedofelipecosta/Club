using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mutualista
{
    public class UpdateMutualistaLAException : Exception
    {
        public UpdateMutualistaLAException()
        {
        }

        public UpdateMutualistaLAException(string? message) : base(message)
        {
        }

        public UpdateMutualistaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateMutualistaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
