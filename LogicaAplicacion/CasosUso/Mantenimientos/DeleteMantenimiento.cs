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
    public class DeleteMantenimiento : DeleteObject<Mantenimiento>
    {
        RepositorioMantenimiento _repo;

        public DeleteMantenimiento(RepositorioMantenimiento repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Mantenimiento obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioMantenimientoException e) { throw new DeleteMantenimientoLAException(e.Message); }
            catch (Exception) { throw new DeleteMantenimientoLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
