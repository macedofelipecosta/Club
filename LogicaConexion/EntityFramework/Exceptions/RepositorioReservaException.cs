using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioReservaException : Exception
    {
        public RepositorioReservaException()
        {
        }

        public RepositorioReservaException(string? message) : base(message)
        {
        }

        public RepositorioReservaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioReservaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
