using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Equipos
{
    public class NewEquipoLAException : DomainException
    {
        public NewEquipoLAException()
        {
        }

        public NewEquipoLAException(string? message) : base(message)
        {
        }

        public NewEquipoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewEquipoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
