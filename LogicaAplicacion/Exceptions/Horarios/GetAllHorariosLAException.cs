using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Horarios
{
    public class GetAllHorariosLAException : Exception
    {
        public GetAllHorariosLAException()
        {
        }

        public GetAllHorariosLAException(string? message) : base(message)
        {
        }

        public GetAllHorariosLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GetAllHorariosLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
