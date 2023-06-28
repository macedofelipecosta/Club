using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Mutualista
{
    public class DeleteMutualistaLAException : Exception
    {
        public DeleteMutualistaLAException()
        {
        }

        public DeleteMutualistaLAException(string? message) : base(message)
        {
        }

        public DeleteMutualistaLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteMutualistaLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
