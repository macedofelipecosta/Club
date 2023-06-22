using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;

namespace LogicaConexion.EntityFramework
{
    public class RepositorioAdministrador:IRepositorioAdministrador
    {
        private ClubContext _context;

        public RepositorioAdministrador(ClubContext context)
        {
            _context = context;
        }

        public void Add(Administrador obj)
        {
            try
            {
                _context.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Administrador obj)
        {
            try
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Administrador Get(int id)
        {
            try
            {
                Administrador admin = _context.Administradores.Where(x => x.Id == id).FirstOrDefault();
                if (admin == null) throw new Exception($"No se han encontrado administradores para el id {id}");
                return admin;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Administrador> GetAll()
        {
            try
            {
                var admins= _context.Administradores.ToList();
                if (admins.IsNullOrEmpty()) throw new Exception("No se han encontrado administradores");
                return admins;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
