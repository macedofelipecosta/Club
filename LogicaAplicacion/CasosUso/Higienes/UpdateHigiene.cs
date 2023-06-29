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
    public class UpdateHigiene : UpdateObject<Higiene>
    {
        RepositorioHigiene _repo;

        public UpdateHigiene(RepositorioHigiene repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Higiene obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioHigieneException e) { throw new UpdateHigieneLAException(e.Message); }
            catch (Exception) { throw new UpdateHigieneLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
