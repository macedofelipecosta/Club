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
                if (obj == null) throw new ArgumentNullException("No se ha recibido un objeto para agregar a la base de datos");
                _context.Mutualistas.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new RepositorioMutualistaException (e.Message);
            }
        }

        public void Delete(Mutualista obj)
        {
            try
            {
                var mutualista = Get(obj.Id);
                _context.Mutualistas.Remove(mutualista);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new RepositorioMutualistaException(e.Message);
            }
        }

        public Mutualista Get(int id)
        {
            try
            {
                var mutualista= _context.Mutualistas.FirstOrDefault(x=>x.Id== id);
                if (mutualista == null) throw new InvalidOperationException("No se ha podido encontrar la mutualista buscada");
                return mutualista;
            }
            catch (Exception e)
            {
                throw new RepositorioMutualistaException(e.Message);
            }
        }

        public IEnumerable<Mutualista> GetAll()
        {
            try
            {
                var mutualistas=_context.Mutualistas.ToList();
                if (mutualistas.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado mutualistas en la base de datos");
                return mutualistas;
            }
            catch (Exception e)
            {
                throw new RepositorioMutualistaException(e.Message);
            }
        }

        public void Update(Mutualista obj)
        {
            try
            {
                var mutualista=Get(obj.Id);
                if (obj.Name.Data!=null) { mutualista.Name.Data = obj.Name.Data; }
                if (obj.Telefono.Data!=null) { mutualista.Telefono.Data = obj.Telefono.Data; }

                _context.Mutualistas.Update(mutualista);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new RepositorioMutualistaException(e.Message);
            }
        }
    }
}
