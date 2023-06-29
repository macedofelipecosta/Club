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
    public class RepositorioHigiene : IRepositorioHigiene
    {
        ClubContext _context;

        public RepositorioHigiene(ClubContext context)
        {
            _context = context;
        }

        public void Add(Higiene obj)
        {
            try
            {
                if (obj == null) { throw new ArgumentNullException("No se ha recibido ninguna orden de limpieza para agregar a la base de datos!"); }
                _context.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioHigieneException(e.Message); }
            catch (Exception) { throw new RepositorioHigieneException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Higiene obj)
        {
            try
            {
                var higiene = Get(obj.Id);
                _context.Higienes.Remove(higiene);
                _context.SaveChanges();
            }
            catch (RepositorioHigieneException e) { throw new RepositorioHigieneException(e.Message); }
            catch (Exception) { throw new RepositorioHigieneException("Ha ocurrido un error inesperado!"); }
        }

        public Higiene Get(int id)
        {
            try
            {
                var higiene = _context.Higienes.FirstOrDefault(h => h.Id == id);
                if (higiene == null) { throw new InvalidOperationException("No se ha encotnrado la orden buscada!"); }
                return higiene;
            }
            catch (InvalidOperationException e) { throw new RepositorioHigieneException(e.Message); }
            catch (Exception) { throw new RepositorioHigieneException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Higiene> GetAll()
        {
            try
            {
                var higienes = _context.Higienes.ToList();
                if (higienes.IsNullOrEmpty()) { throw new InvalidOperationException("No se han encotnrado ordenes de limpieza en la base de datos!"); }
                return higienes;
            }
            catch (InvalidOperationException e) { throw new RepositorioHigieneException(e.Message); }
            catch (Exception) { throw new RepositorioHigieneException("Ha ocurrido un error inesperado!"); }
        }

        public void Update(Higiene obj)
        {
            try
            {
                var higiene = Get(obj.Id);
                if (obj.Sala.Id != 0) { higiene.Sala.Id = obj.Sala.Id; }
                if (obj.Descripcion.Data != null) { higiene.Descripcion.Data = obj.Descripcion.Data; }
                if (obj.Date.Data != DateTime.MinValue) { higiene.Date.Data = obj.Date.Data; }
            }
            catch (RepositorioHigieneException e) { throw new RepositorioHigieneException(e.Message); }
            catch (Exception) { throw new RepositorioHigieneException("Ha ocurrido un error inesperado!"); }
        }
    }
}
