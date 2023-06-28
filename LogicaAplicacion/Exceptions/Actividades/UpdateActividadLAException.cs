using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Actividades
{
    public class UpdateActividadLAException : DomainException
    {
        public UpdateActividadLAException()
        {
        }

        public UpdateActividadLAException(string? message) : base(message)
        {
        }

        public UpdateActividadLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateActividadLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
