using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Colaboradores
{
    public class GetPersonalLAException : Exception
    {
        public GetPersonalLAException()
        {
        }

        public GetPersonalLAException(string? message) : base(message)
        {
        }

        public GetPersonalLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetPersonalLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
