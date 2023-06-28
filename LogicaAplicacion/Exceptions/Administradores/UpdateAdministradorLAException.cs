using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Administradores
{
    public class UpdateAdministradorLAException : DomainException
    {
        public UpdateAdministradorLAException()
        {
        }

        public UpdateAdministradorLAException(string? message) : base(message)
        {
        }

        public UpdateAdministradorLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateAdministradorLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
