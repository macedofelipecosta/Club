using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Equipos
{
    public class GetAllEquipoLAException : DomainException
    {
        public GetAllEquipoLAException()
        {
        }

        public GetAllEquipoLAException(string? message) : base(message)
        {
        }

        public GetAllEquipoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllEquipoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
