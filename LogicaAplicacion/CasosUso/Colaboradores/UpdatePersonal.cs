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
    public class UpdatePersonal : UpdateObject<Personal>
    {
        RepositorioPersonal _repo;

        public UpdatePersonal(RepositorioPersonal repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Personal obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioPersonalException e) { throw new UpdatePersonalLAException(e.Message); }
            catch (Exception) { throw new UpdatePersonalLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
