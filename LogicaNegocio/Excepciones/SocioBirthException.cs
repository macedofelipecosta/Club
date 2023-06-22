using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Excepciones
{
    public class SocioBirthException : DomainException
    {
        public SocioBirthException()
        {
        }

        public SocioBirthException(string? message) : base(message)
        {
        }

        public SocioBirthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SocioBirthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
