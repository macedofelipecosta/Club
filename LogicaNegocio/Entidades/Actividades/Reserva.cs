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
        public int Id { get; set; }
        public int SocioId { get; set; }
        public int ActividadId { get; set; }
        public int SalaId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
