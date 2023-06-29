using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Higiene
{
    public class UpdateHigieneLAException : Exception
    {
        public UpdateHigieneLAException()
        {
        }

        public UpdateHigieneLAException(string? message) : base(message)
        {
        }

        public UpdateHigieneLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateHigieneLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
