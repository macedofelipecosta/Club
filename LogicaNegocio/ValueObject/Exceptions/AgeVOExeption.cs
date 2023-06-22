using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject.Exceptions
{
    internal class AgeVOExeption : DomainException
    {
        public AgeVOExeption()
        {
        }

        public AgeVOExeption(string? message) : base(message)
        {
        }

        public AgeVOExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AgeVOExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
