using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.Exceptions
{
    public class CelphoneNumberVOException : DomainException
    {
        public CelphoneNumberVOException()
        {
        }

        public CelphoneNumberVOException(string? message) : base(message)
        {
        }

        public CelphoneNumberVOException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CelphoneNumberVOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
