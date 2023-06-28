using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Colaboradores
{
    public class NewPersonalLAException : Exception
    {
        public NewPersonalLAException()
        {
        }

        public NewPersonalLAException(string? message) : base(message)
        {
        }

        public NewPersonalLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewPersonalLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
