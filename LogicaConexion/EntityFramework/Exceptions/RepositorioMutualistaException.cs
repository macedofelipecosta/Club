using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioMutualistaException : Exception
    {
        public RepositorioMutualistaException()
        {
        }

        public RepositorioMutualistaException(string? message) : base(message)
        {
        }

        public RepositorioMutualistaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioMutualistaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
