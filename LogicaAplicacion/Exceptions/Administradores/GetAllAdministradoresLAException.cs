using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Administradores
{
    public class GetAllAdministradoresLAException : DomainException
    {
        public GetAllAdministradoresLAException()
        {
        }

        public GetAllAdministradoresLAException(string? message) : base(message)
        {
        }

        public GetAllAdministradoresLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllAdministradoresLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
