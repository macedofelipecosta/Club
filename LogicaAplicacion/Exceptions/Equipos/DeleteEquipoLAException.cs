﻿using LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.Exceptions.Equipos
{
    public class DeleteEquipoLAException : DomainException
    {
        public DeleteEquipoLAException()
        {
        }

        public DeleteEquipoLAException(string? message) : base(message)
        {
        }

        public DeleteEquipoLAException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteEquipoLAException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
