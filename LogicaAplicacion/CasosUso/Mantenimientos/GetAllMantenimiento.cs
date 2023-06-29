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
    public class GetAllMantenimiento : GetAllObject<Mantenimiento>
    {
        RepositorioMantenimiento _repo;

        public GetAllMantenimiento(RepositorioMantenimiento repo)
        {
            _repo = repo;
        }

        public IEnumerable<Mantenimiento> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioMantenimientoException e) { throw new GetAllMantenimientoLAException(e.Message); }
            catch (Exception) { throw new GetAllMantenimientoLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
