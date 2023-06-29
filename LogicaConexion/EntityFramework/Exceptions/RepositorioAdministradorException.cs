using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioAdministradorException : Exception
    {
        public RepositorioAdministradorException()
        {
        }

        public RepositorioAdministradorException(string? message) : base(message)
        {
        }

        public RepositorioAdministradorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioAdministradorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
