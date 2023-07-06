using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class ReservasControllerException : Exception
    {
        public ReservasControllerException()
        {
        }

        public ReservasControllerException(string? message) : base(message)
        {
        }

        public ReservasControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ReservasControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
