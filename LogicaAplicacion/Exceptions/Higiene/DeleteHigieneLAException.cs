using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Higiene
{
    public class DeleteHigieneLAException : Exception
    {
        public DeleteHigieneLAException()
        {
        }

        public DeleteHigieneLAException(string? message) : base(message)
        {
        }

        public DeleteHigieneLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteHigieneLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
