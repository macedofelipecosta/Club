using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioMantenimientoException : Exception
    {
        public RepositorioMantenimientoException()
        {
        }

        public RepositorioMantenimientoException(string? message) : base(message)
        {
        }

        public RepositorioMantenimientoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioMantenimientoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
