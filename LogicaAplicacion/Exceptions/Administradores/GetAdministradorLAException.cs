using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Administradores
{
    public class GetAdministradorLAException : DomainException
    {
        public GetAdministradorLAException()
        {
        }

        public GetAdministradorLAException(string? message) : base(message)
        {
        }

        public GetAdministradorLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAdministradorLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
