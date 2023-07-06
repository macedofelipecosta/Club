using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class HigienesControllerException : Exception
    {
        public HigienesControllerException()
        {
        }

        public HigienesControllerException(string? message) : base(message)
        {
        }

        public HigienesControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected HigienesControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
