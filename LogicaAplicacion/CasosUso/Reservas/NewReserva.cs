using LogicaAplicacion.Exceptions.Reservas;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Actividades;

namespace LogicaAplicacion.CasosUso.Reservas
{
    public class NewReserva : NewObject<Reserva>
    {
        RepositorioReserva _repo;

        public NewReserva(RepositorioReserva repo)
        {
            _repo = repo;
        }

        public void NewObj(Reserva obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (RepositorioReservaException e) { throw new NewReservaLAException(e.Message); }
            catch (Exception) { throw new NewReservaLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
