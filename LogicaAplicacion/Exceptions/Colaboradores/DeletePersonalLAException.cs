using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Colaboradores
{
    public class DeletePersonalLAException : Exception
    {
        public DeletePersonalLAException()
        {
        }

        public DeletePersonalLAException(string? message) : base(message)
        {
        }

        public DeletePersonalLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeletePersonalLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
