using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Higiene
{
    public class GetAllHigieneLAException : Exception
    {
        public GetAllHigieneLAException()
        {
        }

        public GetAllHigieneLAException(string? message) : base(message)
        {
        }

        public GetAllHigieneLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllHigieneLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
