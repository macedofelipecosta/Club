using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Administradores
{
    public class DeleteAdministradorLAException : DomainException
    {
        public DeleteAdministradorLAException()
        {
        }

        public DeleteAdministradorLAException(string? message) : base(message)
        {
        }

        public DeleteAdministradorLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteAdministradorLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
