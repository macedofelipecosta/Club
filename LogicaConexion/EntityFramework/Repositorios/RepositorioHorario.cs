using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
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
                if (obj == null) { throw new ArgumentNullException("No se ha recibido ningun horario para almacenar en base de datos!"); }
                _context.Horarios.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioHorarioException(e.Message); }
            catch (Exception) { throw new RepositorioHorarioException("Ha ocurrido un error inesperado!"); }
        }
        public void Delete(Horario obj)
        {
            try
            {
                var horario = Get(obj.Id);
                _context.Horarios.Remove(horario);
                _context.SaveChanges();
            }
            catch (RepositorioHorarioException e) { throw new RepositorioHorarioException(e.Message); }
            catch (Exception) { throw new RepositorioHorarioException("Ha ocurrido un error inesperado!"); }

        }
        public void Update(Horario obj)
        {
            try
            {
                var horario = Get(obj.Id);
                if (obj.Inicio != DateTime.MinValue) { horario.Inicio = obj.Inicio; }
                if (obj.Fin!=DateTime.MinValue) { horario.Fin = obj.Fin; }
                _context.Horarios.Update(horario);
                _context.SaveChanges();
            }
            catch (RepositorioHorarioException e) { throw new RepositorioHorarioException(e.Message); }
            catch (Exception) { throw new RepositorioHorarioException("Ha ocurrido un error inesperado!"); }
        }
        public Horario Get(int id)
        {
            try
            {
                var horario = _context.Horarios.FirstOrDefault(x => x.Id == id);
                if (horario == null) throw new InvalidOperationException("No se ha encnotrado el horario!");
                return horario;
            }
            catch (InvalidOperationException e) { throw new RepositorioHorarioException(e.Message); }
            catch (Exception) { throw new RepositorioHorarioException("Ha ocurrido un error inesperado!"); }
        }
        public IEnumerable<Horario> GetAll()
        {
            try
            {
                var horarios = _context.Horarios.ToList();
                if (horarios.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado horarios!");
                return horarios;
            }
            catch (InvalidOperationException e) { throw new RepositorioHorarioException(e.Message); }
            catch (Exception) { throw new RepositorioHorarioException("Ha ocurrido un error inesperado!"); }
        }


    }
}
