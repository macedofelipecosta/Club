using LogicaAplicacion.Exceptions.Mantenimientos;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Mantenimientos
{
    public class GetMantenimiento : GetObject<Mantenimiento>
    {
        RepositorioMantenimiento _repo;

        public GetMantenimiento(RepositorioMantenimiento repo)
        {
            _repo = repo;
        }

        public Mantenimiento GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioMantenimientoException e) { throw new GetMantenimientoLAException(e.Message); }
            catch (Exception) { throw new GetMantenimientoLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
