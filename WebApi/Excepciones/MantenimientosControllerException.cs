using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class MantenimientosControllerException : Exception
    {
        public MantenimientosControllerException()
        {
        }

        public MantenimientosControllerException(string? message) : base(message)
        {
        }

        public MantenimientosControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MantenimientosControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
