using System.Runtime.Serialization;

namespace WebApi.Excepciones
{
    public class PersonalsControllerException : Exception
    {
        public PersonalsControllerException()
        {
        }

        public PersonalsControllerException(string? message) : base(message)
        {
        }

        public PersonalsControllerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PersonalsControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
