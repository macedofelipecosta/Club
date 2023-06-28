using LogicaAplicacion.Exceptions.Administradores;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades;


namespace LogicaAplicacion.CasosUso.Administradores
{
    public class DeleteAdministrador : DeleteObject<Administrador>
    {
        RepositorioAdministrador _repo;

        public DeleteAdministrador(RepositorioAdministrador repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Administrador obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (Exception)
            {
                throw new DeleteAdministradorLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
