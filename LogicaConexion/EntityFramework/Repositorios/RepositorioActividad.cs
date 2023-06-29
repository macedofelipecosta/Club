using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Interfaces.IRepositorios;
using LogicaNegocio.ValueObject;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioActividad : IRepositorioActividad
    {
        private ClubContext _context;
        public RepositorioActividad(ClubContext context)
        {
            _context = context;
        }

        public void Add(Actividad obj)
        {
            try
            {
                if (obj == null) { throw new ArgumentNullException("No se ha recibido actividad para guardar en base de datos"); }
                _context.Actividades.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioActividadException(e.Message); }
            catch (Exception) { throw new RepositorioActividadException("Ha ocurrido un error inesperado!"); }
        }
      
        public void Delete(Actividad obj)
        {
            try
            {
                var actividad = Get(obj.Id);
                _context.Actividades.Remove(actividad);
                _context.SaveChanges();
            }
            catch (RepositorioActividadException e) { throw new RepositorioActividadException(e.Message); }
            catch (Exception) { throw new RepositorioActividadException("Ha ocurrido un error inesperado!"); }
        }

        public void Update(Actividad obj)
        {
            try
            {
                var actividad = Get(obj.Id);
                if (obj.Nombre.Data != null) { actividad.Nombre.Data = obj.Nombre.Data; }
                if (obj.Profesor.Id != 0) { actividad.Profesor.Id = obj.Profesor.Id; }
                if (obj.Sala.Id != 0) { actividad.Sala.Id = obj.Sala.Id; }
                if (obj.Horario.Id != 0) { actividad.Horario.Id = obj.Horario.Id; }

                _context.Actividades.Update(actividad);
                _context.SaveChanges();
            }
            catch (RepositorioActividadException e) { throw new RepositorioActividadException(e.Message); }
            catch (Exception) { throw new RepositorioActividadException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Actividad> GetAll()
        {
            try
            {
                var actividades = _context.Actividades.ToList();
                if (actividades.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado actividades en la base de datos!");
                return actividades;
            }
            catch (InvalidOperationException e) { throw new RepositorioActividadException(e.Message); }
            catch (Exception) { throw new RepositorioActividadException("Ha ocurrido un error inesperado!"); }
        }

        public Actividad Get(int id)
        {
            try
            {
                var actividad = _context.Actividades.FirstOrDefault(x => x.Id == id);
                if (actividad == null) throw new InvalidOperationException("No se ha encontrado la actividad buscada!");
                return actividad;
            }
            catch (InvalidOperationException e) { throw new RepositorioActividadException(e.Message); }
            catch (Exception) { throw new RepositorioActividadException("Ha ocurrido un error inesperado!"); }
        }

        
    }
}
