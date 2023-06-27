using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Excepciones
{
    public class SocioAgeException : DomainException
    {
        public SocioAgeException()
        {
        }

        public SocioAgeException(string? message) : base(message)
        {
        }

        public SocioAgeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SocioAgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
