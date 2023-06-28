using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Horarios
{
    public class GetHorariosLAException : Exception
    {
        public GetHorariosLAException()
        {
        }

        public GetHorariosLAException(string? message) : base(message)
        {
        }

        public GetHorariosLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetHorariosLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
