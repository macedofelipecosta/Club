using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Colaboradores
{
    public class UpdatePersonalLAException : Exception
    {
        public UpdatePersonalLAException()
        {
        }

        public UpdatePersonalLAException(string? message) : base(message)
        {
        }

        public UpdatePersonalLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdatePersonalLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
