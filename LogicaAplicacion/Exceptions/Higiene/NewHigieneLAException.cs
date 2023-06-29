using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Higiene
{
    public class NewHigieneLAException : Exception
    {
        public NewHigieneLAException()
        {
        }

        public NewHigieneLAException(string? message) : base(message)
        {
        }

        public NewHigieneLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewHigieneLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
