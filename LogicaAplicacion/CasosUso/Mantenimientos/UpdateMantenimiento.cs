using LogicaAplicacion.Exceptions.Mantenimientos;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Mantenimientos
{
    public class UpdateMantenimiento : UpdateObject<Mantenimiento>
    {
        RepositorioMantenimiento _repo;

        public UpdateMantenimiento(RepositorioMantenimiento repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Mantenimiento obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioMantenimientoException e) { throw new UpdateMantenimientoLAException(e.Message); }
            catch (Exception) { throw new UpdateMantenimientoLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
