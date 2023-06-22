using LogicaNegocio.Excepciones;
using System.Runtime.Serialization;

namespace LogicaNegocio.ValueObject.Exceptions
{
    public class CedulaVOException : DomainException
    {
        public CedulaVOException()
        {
        }

        public CedulaVOException(string? message) : base(message)
        {
        }

        public CedulaVOException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CedulaVOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
