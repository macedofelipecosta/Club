using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        ClubContext _context;

        public RepositorioEquipo(ClubContext context)
        {
            _context = context;
        }

        public void Add(Equipo obj)
        {
            try
            {
                if (obj == null) throw new ArgumentNullException("No se ha recibido un Equipo para guardar en la base de datos");
                _context.Equipos.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Equipo obj)
        {
            try
            {
                var equipo = Get(obj.Id);
                _context.Equipos.Remove(equipo);
                _context.SaveChanges();
            }
            catch (RepositorioEquipoException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado!"); }
        }

        public Equipo Get(int id)
        {
            try
            {
                var equipo = _context.Equipos.FirstOrDefault(x => x.Id == id);
                if (equipo == null) throw new InvalidOperationException("No se ha encontrado el equipo buscado");
                return equipo;
            }
            catch (InvalidOperationException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Equipo> GetAll()
        {
            try
            {
                var equipos = _context.Equipos.ToList();
                if (equipos.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado equipos en la base de datos");
                return equipos;
            }
            catch (InvalidOperationException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado!"); }
        }

        public void Update(Equipo obj)
        {
            try
            {
                var equipo = Get(obj.Id);
                if (obj.Nombre.Data != null) { equipo.Nombre.Data = obj.Nombre.Data; }
                if (obj.Descripcion.Data != null) { equipo.Descripcion.Data = obj.Descripcion.Data; }

                _context.Equipos.Update(equipo);
                _context.SaveChanges();
            }
            catch (RepositorioEquipoException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado!"); }
        }
    }
}
