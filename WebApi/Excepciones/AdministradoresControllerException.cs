using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class AdministradoresControllerException : Exception
    {
        public AdministradoresControllerException()
        {
        }

        public AdministradoresControllerException(string? message) : base(message)
        {
        }

        public AdministradoresControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AdministradoresControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
