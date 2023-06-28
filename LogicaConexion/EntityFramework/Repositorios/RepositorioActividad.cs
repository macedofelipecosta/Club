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
                _context.Actividades.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
      
        public void Delete(Actividad obj)
        {
            try
            {
                var actividad = Get(obj.Id);
                _context.Actividades.Remove(actividad);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Update(Actividad obj)
        {
            try
            {
                var actividad = Get(obj.Id);
                if (actividad == null) throw new Exception($"No se ha encontrado la actividad con id {obj.Id}");
                if (obj.Nombre.Data == null) { throw new Exception($"No se ha encontrado un nombre para modificar"); };
                if (obj.Horario.Id == null) { throw new Exception($"No se han encontrado un horario para modificar"); };
                if (obj.Profesor.Id == null) { throw new Exception($"No se han encontrado profesor para modificar"); };
                if (obj.Sala.Id == null) { throw new Exception($"No se han encontrado sala para modificar"); };

                actividad.Nombre.Data = obj.Nombre.Data;
                actividad.Horario.Id = obj.Horario.Id;
                actividad.Profesor.Id = obj.Profesor.Id;
                actividad.Sala.Id = obj.Sala.Id;

                _context.Actividades.Update(actividad);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<Actividad> GetAll()
        {
            try
            {
                var actividades = _context.Actividades.ToList();
                if (actividades.IsNullOrEmpty()) throw new Exception("No se han encontrado actividades!");
                return actividades;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Actividad Get(int id)
        {
            try
            {
                var actividad = _context.Actividades.FirstOrDefault(x => x.Id == id);
                if (actividad == null) throw new Exception("No se ha encontrado la actividad!");
                return actividad;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        
    }
}
