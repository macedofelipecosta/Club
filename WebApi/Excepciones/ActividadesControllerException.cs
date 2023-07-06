using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class ActividadesControllerException : Exception
    {
        public ActividadesControllerException()
        {
        }

        public ActividadesControllerException(string? message) : base(message)
        {
        }

        public ActividadesControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ActividadesControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
