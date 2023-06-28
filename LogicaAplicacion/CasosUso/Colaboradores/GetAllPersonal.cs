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
    public class GetAllPersonal : GetAllObject<Personal>
    {
        RepositorioPersonal _repo;

        public GetAllPersonal(RepositorioPersonal repo)
        {
            _repo = repo;
        }

        public IEnumerable<Personal> GetAllObj()
        {
            try
            {
               return _repo.GetAll();
            }
            catch (RepositorioPersonalException e) { throw new GetAllPersonalLAException(e.Message); }
            catch (Exception) { throw new GetAllPersonalLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
