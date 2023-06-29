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
    public class GetHigiene : GetObject<Higiene>
    {
        RepositorioHigiene _repo;

        public GetHigiene(RepositorioHigiene repo)
        {
            _repo = repo;
        }

        public Higiene GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch(RepositorioHigieneException e) { throw new GetHigieneLAException(e.Message); }
            catch (Exception) { throw new GetHigieneLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
