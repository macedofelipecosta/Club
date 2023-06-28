using LogicaAplicacion.Exceptions.Salas;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Instalaciones;

namespace LogicaAplicacion.CasosUso.Salas
{
    public class GetSala : GetObject<Sala>
    {
        RepositorioSala _repo;

        public GetSala(RepositorioSala repo)
        {
            _repo = repo;
        }

        public Sala GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioSalaException e) { throw new GetSalaLAException(e.Message); }
            catch (Exception) { throw new GetSalaLAException("Se ha producido un error inesperado!"); }
        }
    }
}
