using LogicaNegocio.Entidades.Instalaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades.Actividades
{
    public class Reserva
    {
        public int NumeroReserva { get; set; }
        public Socio Socio { get; set; }
        public Actividad Actividad { get; set; }
        public Sala Sala { get; set; }
        public DateTime Fecha { get; set; }
    }
}
