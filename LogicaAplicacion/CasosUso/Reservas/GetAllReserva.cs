using LogicaAplicacion.Exceptions.Reservas;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Reservas
{
    public class GetAllReserva : GetAllObject<Reserva>
    {
        RepositorioReserva _repo;

        public GetAllReserva(RepositorioReserva repo)
        {
            _repo = repo;
        }

        public IEnumerable<Reserva> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioReservaException e) { throw new GetAllReservaLAException(e.Message); }
            catch (Exception) { throw new GetAllReservaLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
