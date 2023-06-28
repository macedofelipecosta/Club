using LogicaConexion.EntityFramework.Exceptions;
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
                if (obj == null) { throw new ArgumentNullException(nameof(obj)); }
                _context.Empleados.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioPersonalException(e.Message); }
            catch (Exception) { throw new RepositorioPersonalException("Ha ocurrido un error inesperado!"); }
        }

        public Personal Get(int id)
        {
            try
            {
                var empleado = _context.Empleados.FirstOrDefault(X => X.Id == id);
                if (empleado == null) throw new InvalidOperationException($"No se ha encontrado al empleado con id: {id}");
                return empleado;
            }
            catch (InvalidOperationException e) { throw new RepositorioPersonalException(e.Message); }
            catch (Exception) { throw new RepositorioPersonalException("Ha ocurrido un error inesperado!"); }

        }

        public IEnumerable<Personal> GetAll()
        {
            try
            {
                var list = _context.Empleados.ToList();
                if (list.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado empleados!");
                return list;
            }
            catch (InvalidOperationException e) { throw new RepositorioPersonalException(e.Message); }
            catch (Exception) { throw new RepositorioPersonalException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Personal obj)
        {
            try
            {
                var empleado = Get(obj.Id);
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();

            }
            catch (RepositorioPersonalException e){throw new RepositorioPersonalException(e.Message);}
            catch (Exception) { throw new RepositorioPersonalException("Ha ocurrido un error inesperado!"); }
        }


        public void Update(Personal obj)
        {
            try
            {
                var personal = Get(obj.Id);
                if (obj.Name.Data != null) { personal.Name.Data = obj.Name.Data; };
                if (obj.Apellido.Data != null) { personal.Apellido.Data = obj.Apellido.Data; };
                if (obj.Cedula != null) { personal.Cedula.Data = obj.Cedula.Data; };
                if (obj.Domicilio.Data != null) { personal.Domicilio.Data = obj.Domicilio.Data; };
                if (obj.Contacto != null) { personal.Contacto.Telefono1.Data = obj.Contacto.Telefono1.Data; };
                if (obj.Horario != null) { personal.Horario.Id = obj.Horario.Id; };
                _context.Empleados.Update(personal);
                _context.SaveChanges();
            }
            catch (RepositorioPersonalException e) { throw new RepositorioPersonalException(e.Message); }
            catch (Exception) { throw new RepositorioPersonalException("Ha ocurrido un error inesperado!"); }
        }
    }
}
