using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Servicios;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioMantenimiento : IRepositorioMantenimiento
    {
        ClubContext _context;

        public RepositorioMantenimiento(ClubContext context)
        {
            _context = context;
        }

        public void Add(Mantenimiento obj)
        {
            try
            {
                if(obj == null) { throw new ArgumentNullException("No se ha recibido un mantenimiento para agregar a la base de datos!"); }
            }
            catch (ArgumentNullException e){ throw new RepositorioMantenimientoException(e.Message); }
            catch (Exception) { throw new RepositorioMantenimientoException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Mantenimiento obj)
        {
            try
            {
                var mantenimiento = Get(obj.Id);
                _context.Mantenimientos.Remove(mantenimiento);
                _context.SaveChanges();
            }
            catch (RepositorioMantenimientoException e) { throw new RepositorioMantenimientoException(e.Message); }
            catch (Exception) { throw new RepositorioMantenimientoException("Ha ocurrido un error inesperado!"); }
        }

        public Mantenimiento Get(int id)
        {
            try
            {
                var mantenimiento=_context.Mantenimientos.FirstOrDefault(x => x.Id == id);
                if (mantenimiento == null) { throw new InvalidOperationException($"No se ha encontrado ningún mantenimiento con el id:{id} "); }
                return mantenimiento;
            }
            catch (InvalidOperationException e) { throw new RepositorioMantenimientoException(e.Message); }
            catch (Exception) { throw new RepositorioMantenimientoException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Mantenimiento> GetAll()
        {
            try
            {
                var mantenimientos = _context.Mantenimientos.ToList();
                if (mantenimientos.IsNullOrEmpty()) { throw new InvalidOperationException($"No se han encontrado mantenimientos en la base de datos "); }
                return mantenimientos;
            }
            catch (InvalidOperationException e) { throw new RepositorioMantenimientoException(e.Message); }
            catch (Exception) { throw new RepositorioMantenimientoException("Ha ocurrido un error inesperado!"); }
        }

        public void Update(Mantenimiento obj)
        {
            try
            {
                var mantenimiento = Get(obj.Id);
                if (obj.Sala.Id != 0) { mantenimiento.Sala.Id = obj.Sala.Id; }
                if (obj.Equipo.Id != 0) { mantenimiento.Equipo.Id = obj.Equipo.Id; }
                if (obj.Tecnico.Id != 0) { mantenimiento.Tecnico.Id = obj.Tecnico.Id; }
                if (obj.Descripcion.Data != null) { mantenimiento.Descripcion.Data = obj.Descripcion.Data; }
                if (obj.Date.Data != DateTime.MinValue) { mantenimiento.Date.Data = obj.Date.Data; }
                _context.Mantenimientos.Update(mantenimiento);
                _context.SaveChanges();

            }
            catch (RepositorioMantenimientoException e) { throw new RepositorioMantenimientoException(e.Message); }
            catch (Exception) { throw new RepositorioMantenimientoException("Ha ocurrido un error inesperado!"); }
        }
    }
}
