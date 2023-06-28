using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Colaboradores
{
    public class GetAllPersonalLAException : Exception
    {
        public GetAllPersonalLAException()
        {
        }

        public GetAllPersonalLAException(string? message) : base(message)
        {
        }

        public GetAllPersonalLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllPersonalLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
