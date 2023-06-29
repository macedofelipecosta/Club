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
    public class NewMantenimiento : NewObject<Mantenimiento>
    {
        RepositorioMantenimiento _repo;

        public NewMantenimiento(RepositorioMantenimiento repo)
        {
            _repo = repo;
        }

        public void NewObj(Mantenimiento obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (RepositorioMantenimientoException e) { throw new NewMantenimientoLAException(e.Message); }
            catch (Exception) { throw new NewMantenimientoLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
