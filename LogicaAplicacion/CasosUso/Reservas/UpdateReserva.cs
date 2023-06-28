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
    public class UpdateReserva : UpdateObject<Reserva>
    {
        RepositorioReserva _repo;

        public UpdateReserva(RepositorioReserva repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Reserva obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioReservaException e) { throw new UpdateReservaLAException(e.Message); }
            catch (Exception) { throw new UpdateReservaLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
