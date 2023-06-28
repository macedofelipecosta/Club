using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Horarios
{
    public class NewHorarioLAException : Exception
    {
        public NewHorarioLAException()
        {
        }

        public NewHorarioLAException(string? message) : base(message)
        {
        }

        public NewHorarioLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewHorarioLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
