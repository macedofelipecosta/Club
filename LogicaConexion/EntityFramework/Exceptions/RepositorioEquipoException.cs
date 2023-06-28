using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioEquipoException : Exception
    {
        public RepositorioEquipoException()
        {
        }

        public RepositorioEquipoException(string? message) : base(message)
        {
        }

        public RepositorioEquipoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioEquipoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
