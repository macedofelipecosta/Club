using LogicaAplicacion.Exceptions.Higiene;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Servicios;

namespace LogicaAplicacion.CasosUso.Higienes
{
    public class NewHigiene : NewObject<Higiene>
    {
        RepositorioHigiene _repo;

        public NewHigiene(RepositorioHigiene repo)
        {
            _repo = repo;
        }

        public void NewObj(Higiene obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (RepositorioHigieneException e) { throw new NewHigieneLAException(e.Message); }
            catch (Exception) { throw new NewHigieneLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
