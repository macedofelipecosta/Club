using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Actividades
{
    public class GetAllActividadesLAException : DomainException
    {
        public GetAllActividadesLAException()
        {
        }

        public GetAllActividadesLAException(string? message) : base(message)
        {
        }

        public GetAllActividadesLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllActividadesLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
