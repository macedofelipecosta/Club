using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Equipos
{
    public class UpdateEquipoLAException : DomainException
    {
        public UpdateEquipoLAException()
        {
        }

        public UpdateEquipoLAException(string? message) : base(message)
        {
        }

        public UpdateEquipoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateEquipoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
