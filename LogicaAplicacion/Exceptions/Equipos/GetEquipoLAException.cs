using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Equipos
{
    public class GetEquipoLAException : DomainException
    {
        public GetEquipoLAException()
        {
        }

        public GetEquipoLAException(string? message) : base(message)
        {
        }

        public GetEquipoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetEquipoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
