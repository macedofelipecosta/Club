using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.Exceptions
{
    public class NameVOException : DomainException
    {
        public NameVOException()
        {
        }

        public NameVOException(string? message) : base(message)
        {
        }

        public NameVOException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NameVOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
