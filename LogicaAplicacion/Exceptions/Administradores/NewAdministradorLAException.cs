using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Administradores
{
    public class NewAdministradorLAException : DomainException
    {
        public NewAdministradorLAException()
        {
        }

        public NewAdministradorLAException(string? message) : base(message)
        {
        }

        public NewAdministradorLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewAdministradorLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
