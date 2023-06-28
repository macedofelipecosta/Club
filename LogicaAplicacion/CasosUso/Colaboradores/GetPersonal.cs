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
    public class GetPersonal : GetObject<Personal>
    {
        RepositorioPersonal _repo;

        public GetPersonal(RepositorioPersonal repo)
        {
            _repo = repo;
        }

        public Personal GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioPersonalException e) { throw new GetPersonalLAException(e.Message); }
            catch (Exception) { throw new GetPersonalLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
