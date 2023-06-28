using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Actividades
{
    public class NewActividadLAException : DomainException
    {
        public NewActividadLAException()
        {
        }

        public NewActividadLAException(string? message) : base(message)
        {
        }

        public NewActividadLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewActividadLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
