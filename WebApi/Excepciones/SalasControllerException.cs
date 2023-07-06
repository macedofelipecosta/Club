using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class SalasControllerException : Exception
    {
        public SalasControllerException()
        {
        }

        public SalasControllerException(string? message) : base(message)
        {
        }

        public SalasControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SalasControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
