using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Horarios
{
    public class UpdateHorariosLAException : Exception
    {
        public UpdateHorariosLAException()
        {
        }

        public UpdateHorariosLAException(string? message) : base(message)
        {
        }

        public UpdateHorariosLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateHorariosLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
