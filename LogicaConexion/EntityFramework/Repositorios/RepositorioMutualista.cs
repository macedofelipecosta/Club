using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioMutualista : IRepositorioMutualista
    {
        ClubContext _context;

        public RepositorioMutualista(ClubContext context)
        {
            _context = context;
        }

        public void Add(Mutualista obj)
        {
            try
            {
                if (obj == null) throw new ArgumentNullException("No se ha recibido una mutualista para agregar a la base de datos");
                _context.Mutualistas.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
            catch (Exception) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Mutualista obj)
        {
            try
            {
                var mutualista = Get(obj.Id);
                _context.Mutualistas.Remove(mutualista);
                _context.SaveChanges();
            }
            catch (RepositorioMutualistaException) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
            catch (Exception) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
        }

        public Mutualista Get(int id)
        {
            try
            {
                var mutualista= _context.Mutualistas.FirstOrDefault(x=>x.Id== id);
                if (mutualista == null) throw new InvalidOperationException("No se ha podido encontrar la mutualista buscada");
                return mutualista;
            }
            catch (InvalidOperationException) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
            catch (Exception) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Mutualista> GetAll()
        {
            try
            {
                var mutualistas=_context.Mutualistas.ToList();
                if (mutualistas.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado mutualistas en la base de datos");
                return mutualistas;
            }
            catch (InvalidOperationException) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
            catch (Exception) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
        }

        public void Update(Mutualista obj)
        {
            try
            {
                var mutualista=Get(obj.Id);
                if (obj.Name.Data!=null) { mutualista.Name.Data = obj.Name.Data; }
                if (obj.Telefono.Data!=null) { mutualista.Telefono.Data = obj.Telefono.Data; }
                if (obj.Emergencia.Data!=null) { mutualista.Emergencia.Data = obj.Emergencia.Data; }
                _context.Mutualistas.Update(mutualista);
                _context.SaveChanges();
            }
            catch (RepositorioMutualistaException) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
            catch (Exception) { throw new RepositorioMutualistaException("Ha ocurrido un error inesperado!"); }
        }
    }
}
