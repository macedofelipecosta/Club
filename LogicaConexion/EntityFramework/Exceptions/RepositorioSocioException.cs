using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioSocioException : Exception
    {
        public RepositorioSocioException()
        {
        }

        public RepositorioSocioException(string? message) : base(message)
        {
        }

        public RepositorioSocioException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioSocioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
