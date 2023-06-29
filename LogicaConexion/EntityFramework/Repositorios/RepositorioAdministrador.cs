using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioAdministrador : IRepositorioAdministrador
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
                if (obj == null) { throw new ArgumentNullException("No se ha recibido administrador para guardar en base de datos!"); }
                _context.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioAdministradorException(e.Message); }
            catch (Exception) { throw new RepositorioAdministradorException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Administrador obj)
        {
            try
            {
                var admin = Get(obj.Id);
                _context.Remove(admin);
                _context.SaveChanges();
            }
            catch (RepositorioAdministradorException e) { throw new RepositorioAdministradorException(e.Message); }
            catch (Exception) { throw new RepositorioAdministradorException("Ha ocurrido un error inesperado!"); }
        }
        public void Update(Administrador obj)
        {
            try
            {
                var admin = Get(obj.Id);
                if (obj.Name.Data != null) {admin.Name.Data = obj.Name.Data; }
                if(obj.Email.Data != null) { admin.Email.Data = obj.Email.Data; }

                _context.Administradores.Update(admin);
                _context.SaveChanges();
            }
            catch (RepositorioAdministradorException e) { throw new RepositorioAdministradorException(e.Message); }
            catch (Exception) { throw new RepositorioAdministradorException("Ha ocurrido un error inesperado!"); }
        }
        public Administrador Get(int id)
        {
            try
            {
                var admin = _context.Administradores.FirstOrDefault(x => x.Id == id);
                if (admin == null) throw new InvalidOperationException($"No se han encontrado administradores con el id: {id}");
                return admin;
            }
            catch (InvalidOperationException e) { throw new RepositorioAdministradorException(e.Message); }
            catch (Exception) { throw new RepositorioAdministradorException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Administrador> GetAll()
        {
            try
            {
                var admins = _context.Administradores.ToList();
                if (admins.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado administradores en la base de datos!");
                return admins;
            }
            catch (InvalidOperationException e) { throw new RepositorioAdministradorException(e.Message); }
            catch (Exception) { throw new RepositorioAdministradorException("Ha ocurrido un error inesperado!"); }
        }
    }
}
