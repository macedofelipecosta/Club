using LogicaAplicacion.Exceptions.Higiene;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Higienes
{
    public class GetAllHigiene : GetAllObject<Higiene>
    {
        RepositorioHigiene _repo;

        public GetAllHigiene(RepositorioHigiene repo)
        {
            _repo = repo;
        }

        public IEnumerable<Higiene> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioHigieneException e) { throw new GetAllHigieneLAException(e.Message); }
            catch (Exception) { throw new GetAllHigieneLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
