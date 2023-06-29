using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Higiene
{
    public class GetHigieneLAException : Exception
    {
        public GetHigieneLAException()
        {
        }

        public GetHigieneLAException(string? message) : base(message)
        {
        }

        public GetHigieneLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetHigieneLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
