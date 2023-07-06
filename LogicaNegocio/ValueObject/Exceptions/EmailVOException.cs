using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.Exceptions
{
    public class EmailVOException : Exception
    {
        public EmailVOException()
        {
        }

        public EmailVOException(string? message) : base(message)
        {
        }

        public EmailVOException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmailVOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
