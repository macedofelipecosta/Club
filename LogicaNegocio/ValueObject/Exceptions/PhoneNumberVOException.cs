using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.Exceptions
{
    public class PhoneNumberVOException : DomainException
    {
        public PhoneNumberVOException()
        {
        }

        public PhoneNumberVOException(string? message) : base(message)
        {
        }

        public PhoneNumberVOException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PhoneNumberVOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
