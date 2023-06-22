using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework
{
    public class RepositorioHorario : IRepositorioHorario
    {
        private ClubContext _context;
        public RepositorioHorario(ClubContext context)
        {
            _context = context;
        }

        public void Add(Horario obj)
        {
            try
            {
                _context.Horarios.Add(obj);
            }
            catch (Exception e)
            {
                throw new Exception("No se ha podido crear el horario!");
            }
        }
        public void Remove(int id)
        {
            var horario = GetHorario(id);
            if (horario == null) throw new InvalidOperationException("No se ha podido eliminar este horario porque no se ha encontrado!");
            _context.Horarios.Remove(horario);
            _context.SaveChanges();
        }
        public void Edit(int id, DateTime inicio, DateTime fin)
        {
            try
            {
                ValidarHorario(inicio, fin);
                var horario = GetHorario(id);
                horario.Inicio = inicio;
                horario.Fin = fin;

                _context.Horarios.Update(horario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void ValidarHorario(DateTime inicio, DateTime fin)
        {
            if (inicio > fin) throw new ArgumentException("La hora de inicio no puede ser mayor a la de fin");
            TimeSpan tiempo = inicio.Subtract(fin);
            int minutos = (int)tiempo.TotalMinutes;
            if (minutos < 40) throw new InvalidOperationException("La actividad debe ser mayor a 40 minutos!");
        }

        public Horario GetHorario(int id)
        {
            try
            {
                var horario = _context.Horarios.FirstOrDefault(x => x.Id == id);
                if (horario == null) throw new Exception("No se ha encnotrado el horario!");
                return horario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<Horario> GetAll()
        {
            try
            {
                var horarios = _context.Horarios.ToList();
                if (horarios.IsNullOrEmpty()) throw new Exception("No se han encontrado horarios!");
                return horarios;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
