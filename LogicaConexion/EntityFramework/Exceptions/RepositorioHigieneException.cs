using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioHigieneException : Exception
    {
        public RepositorioHigieneException()
        {
        }

        public RepositorioHigieneException(string? message) : base(message)
        {
        }

        public RepositorioHigieneException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioHigieneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
