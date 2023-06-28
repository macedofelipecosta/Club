using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Horarios
{
    public class DeleteHorariosLAException : Exception
    {
        public DeleteHorariosLAException()
        {
        }

        public DeleteHorariosLAException(string? message) : base(message)
        {
        }

        public DeleteHorariosLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteHorariosLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
