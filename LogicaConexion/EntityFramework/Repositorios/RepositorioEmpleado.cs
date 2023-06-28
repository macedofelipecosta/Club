using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Empleados;
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
    public class RepositorioPersonal : IRepositorioPersonal
    {
        private ClubContext _context;
        public RepositorioPersonal(ClubContext context)
        {
            _context = context;
        }


        public void Add(Personal obj)
        {
            try
            {
                _context.Empleados.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Personal Get(int id)
        {
            var empleado = _context.Empleados.FirstOrDefault(X => X.Id == id);
            if (empleado == null) throw new InvalidOperationException($"No se ha encontrado al empleado con id: {id}");
            return empleado;
        }
        public IEnumerable<Personal> GetAll()
        {
            try
            {
                var list = _context.Empleados.ToList();
                if (list.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado empleados!");
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Personal obj)
        {
            var empleado = GetById(obj.Id);
            if (empleado != null)
            {
                try
                {
                    _context.Empleados.Remove(empleado);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("No se ha podido eliminar al empleado!");
                }
            }
            else
            {
                throw new InvalidOperationException("No se ha encontrado al empleado!");
            }
        }


        public void Update(Personal obj)
        {
            try
            {
                var personal = Get(obj.Id);
                if (personal == null) throw new Exception($"No se ha encontrado la actividad con id {obj.Id}");
                if (obj.Name.Data != null) { personal.Name.Data = obj.Name.Data; };
                if (obj.Apellido.Data != null) { personal.Apellido.Data = obj.Apellido.Data; };
                if (obj.Cedula != null) { personal.Cedula.Data=obj.Cedula.Data; };
                if (obj.Domicilio.Data != null) { personal.Domicilio.Data = obj.Domicilio.Data; };
                if (obj.Contacto != null) { personal.Contacto.Telefono1.Data = obj.Contacto.Telefono1.Data; };
                if (obj.Horario != null) { personal.Horario.Id = obj.Horario.Id; };


                _context.Empleados.Update(personal);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
