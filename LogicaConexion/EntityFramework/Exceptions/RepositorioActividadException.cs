using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioActividadException : Exception
    {
        public RepositorioActividadException()
        {
        }

        public RepositorioActividadException(string? message) : base(message)
        {
        }

        public RepositorioActividadException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioActividadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
