using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class MutualistasControllerException : Exception
    {
        public MutualistasControllerException()
        {
        }

        public MutualistasControllerException(string? message) : base(message)
        {
        }

        public MutualistasControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MutualistasControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
