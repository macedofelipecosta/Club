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
        public void Update(Administrador obj)
        {
            try
            {
                var administrador = Get(obj.Id);
                if (administrador == null) throw new Exception($"No se ha encontrado la actividad con id {obj.Id}");
                if (obj.Name.Data== null) { throw new Exception($"No se ha encontrado un nombre para modificar"); };
                if (obj.Email.Data == null) { throw new Exception($"No se han encontrado un horario para modificar"); };

                administrador.Name.Data = obj.Name.Data;
                administrador.Email.Data = obj.Email.Data;
             
                _context.Administradores.Update(administrador);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
                var admins = _context.Administradores.ToList();
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
