using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Actividades
{
    public class DeleteActividadLAException : DomainException
    {
        public DeleteActividadLAException()
        {
        }

        public DeleteActividadLAException(string? message) : base(message)
        {
        }

        public DeleteActividadLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteActividadLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
