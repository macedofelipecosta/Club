using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Actividades
{
    public class GetActividadLAException : DomainException
    {
        public GetActividadLAException()
        {
        }

        public GetActividadLAException(string? message) : base(message)
        {
        }

        public GetActividadLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetActividadLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
