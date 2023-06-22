using LogicaNegocio.Excepciones;
using System.Runtime.Serialization;

namespace LogicaNegocio.ValueObject.Exceptions
{
    public class DateVOException : DomainException
    {
        public DateVOException()
        {
        }

        public DateVOException(string? message) : base(message)
        {
        }

        public DateVOException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DateVOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
