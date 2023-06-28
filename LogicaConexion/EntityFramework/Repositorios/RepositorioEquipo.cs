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
                if (obj == null) throw new RepositorioEquipoException("No se ha recibido un Equipo para almacenar");
                if (obj.Nombre.Data.IsNullOrEmpty()) throw new RepositorioEquipoException("El nombre del equipo se encuentra vacio");
                _context.Equipos.Add(obj);
                _context.SaveChanges();
            }
            catch (RepositorioEquipoException e)
            {

                throw new RepositorioEquipoException(e.Message);
            }
        }

        public void Delete(Equipo obj)
        {
            try
            {
                var equipo = Get(obj.Id);
                _context.Equipos.Remove(equipo);
                _context.SaveChanges();
            }
            catch (RepositorioEquipoException e){throw new RepositorioEquipoException(e.Message);}
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado"); }
        }

        public Equipo Get(int id)
        {
            try
            {
                var equipo = _context.Equipos.FirstOrDefault(x => x.Id == id);
                if (equipo == null) throw new RepositorioEquipoException("No se ha encontrado el equipo buscado");
                return equipo;
            }
            catch (RepositorioEquipoException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado"); }
        }

        public IEnumerable<Equipo> GetAll()
        {
            try
            {
                var equipos = _context.Equipos.ToList();
                if (equipos.IsNullOrEmpty()) throw new RepositorioEquipoException("No se han encontrado equipos en la base de datos");
                return equipos;
            }
            catch (RepositorioEquipoException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado"); }
        }

        public void Update(Equipo obj)
        {
            try
            {
                if (obj == null) throw new RepositorioEquipoException("No se ha podido actualizar el equipo");
                var equipo = Get(obj.Id);
                if(obj.Nombre.Data!=null) { equipo.Nombre.Data = obj.Nombre.Data; }
                if (obj.Descripcion.Data != null) { equipo.Descripcion.Data = obj.Descripcion.Data; }

                _context.Equipos.Update(equipo);
                _context.SaveChanges();
            }
            catch (RepositorioEquipoException e) { throw new RepositorioEquipoException(e.Message); }
            catch (Exception) { throw new RepositorioEquipoException("Ha ocurrido un error inesperado"); }
        }
    }
}
