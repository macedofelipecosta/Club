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
    public class DeleteReserva : DeleteObject<Reserva>
    {
        RepositorioReserva _repo;

        public DeleteReserva(RepositorioReserva repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Reserva obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioReservaException e) { throw new DeleteReservaLAException(e.Message); }
            catch (Exception) { throw new DeleteReservaLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
