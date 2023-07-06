using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class HorariosControllerException : Exception
    {
        public HorariosControllerException()
        {
        }

        public HorariosControllerException(string? message) : base(message)
        {
        }

        public HorariosControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected HorariosControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
