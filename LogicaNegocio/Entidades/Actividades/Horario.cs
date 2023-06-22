using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades.Actividades
{
    public class Horario
    {
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }



        public Horario() {
            ValidarHorario(this.Inicio, this.Fin);
        }



        private void ValidarHorario(DateTime inicio, DateTime fin)
        {
            if (inicio > fin) throw new ArgumentException("La hora de inicio no puede ser mayor a la de fin");
            TimeSpan tiempo = inicio.Subtract(fin);
            int minutos = (int)tiempo.TotalMinutes;
            if (minutos < 40) throw new InvalidOperationException("La actividad debe ser mayor a 40 minutos!");
        }
    }
}
