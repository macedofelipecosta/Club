using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioPersonalException : Exception
    {
        public RepositorioPersonalException()
        {
        }

        public RepositorioPersonalException(string? message) : base(message)
        {
        }

        public RepositorioPersonalException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioPersonalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
