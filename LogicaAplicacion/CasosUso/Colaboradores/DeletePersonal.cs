using LogicaAplicacion.Exceptions.Colaboradores;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Colaboradores
{
    public class DeletePersonal : DeleteObject<Personal>
    {
        RepositorioPersonal _repo;

        public DeletePersonal(RepositorioPersonal repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Personal obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioPersonalException e) { throw new DeletePersonalLAException(e.Message); }
            catch (Exception) { throw new DeletePersonalLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
