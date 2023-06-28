using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioSalaException : Exception
    {
        public RepositorioSalaException()
        {
        }

        public RepositorioSalaException(string? message) : base(message)
        {
        }

        public RepositorioSalaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioSalaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
