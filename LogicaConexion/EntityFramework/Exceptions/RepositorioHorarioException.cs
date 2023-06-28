using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Exceptions
{
    public class RepositorioHorarioException : Exception
    {
        public RepositorioHorarioException()
        {
        }

        public RepositorioHorarioException(string? message) : base(message)
        {
        }

        public RepositorioHorarioException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepositorioHorarioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
