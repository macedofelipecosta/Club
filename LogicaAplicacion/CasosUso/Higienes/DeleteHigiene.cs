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
    public class DeleteHigiene : DeleteObject<Higiene>
    {
        RepositorioHigiene _repo;

        public DeleteHigiene(RepositorioHigiene repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Higiene obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioHigieneException e) { throw new DeleteHigieneLAException(e.Message); }
            catch (Exception) { throw new DeleteHigieneLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
