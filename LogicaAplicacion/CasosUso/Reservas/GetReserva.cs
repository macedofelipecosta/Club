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
    public class GetReserva : GetObject<Reserva>
    {
        RepositorioReserva _repo;

        public GetReserva(RepositorioReserva repo)
        {
            _repo = repo;
        }

        public Reserva GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioReservaException e) { throw new GetReservaLAException(e.Message); }
            catch (Exception) { throw new GetReservaLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
