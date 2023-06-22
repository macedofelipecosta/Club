using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework
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
                throw new Exception (e.Message);
            }
        }

        public void Update(int id,string nombre,Horario horario, Profesor profesor, Sala sala )
        {
            try
            {
                var actividad=GetById(id );
                if (nombre != null) { nombre = actividad.Nombre; };
                if (horario != null) { horario = actividad.Horario; };
                if (profesor != null) { profesor = actividad.Profesor; };
                if (sala != null) { sala = actividad.Sala; };

                actividad.Nombre = nombre;
                actividad.Horario = horario;
                actividad.Profesor = profesor;
                actividad.Sala = sala;

                _context.Actividades.Update(actividad);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }

        }
        public void Delete(Actividad obj)
        {
            try
            {
                var actividad = GetById(obj.Id);
                _context.Actividades.Remove(actividad);
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
        public Actividad GetById(int id)
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
