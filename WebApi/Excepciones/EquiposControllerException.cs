using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class EquiposControllerException : Exception
    {
        public EquiposControllerException()
        {
        }

        public EquiposControllerException(string? message) : base(message)
        {
        }

        public EquiposControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EquiposControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
