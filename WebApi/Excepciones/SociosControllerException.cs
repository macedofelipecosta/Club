using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class SociosControllerException : Exception
    {
        public SociosControllerException()
        {
        }

        public SociosControllerException(string? message) : base(message)
        {
        }

        public SociosControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SociosControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
