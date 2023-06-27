using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Interfaces.IRepositorios;
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

        public void Update(int id, string nombre, string apellido, string cedula,
                            string domicilio, string telefono, Horario horario)
        {
            try
            {
                var empleado = GetById(id);
                if (nombre != null)
                    empleado.Name.Data = nombre;
                if (apellido != null)
                    empleado.Apellido.Data = apellido;
                if (cedula != null)
                    empleado.Cedula.Data = cedula;
                if (domicilio != null)
                    empleado.Domicilio.Data = domicilio;
                if (telefono != null)
                    empleado.Contacto.Telefono1.Data = telefono;
                empleado.Horario = horario;

                _context.Empleados.Update(empleado);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            var empleado = GetById(id);
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
        public Personal GetById(int id)
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

    }
}
