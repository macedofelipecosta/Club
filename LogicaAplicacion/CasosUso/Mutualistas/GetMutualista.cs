using LogicaAplicacion.Exceptions.Mutualista;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Mutualistas
{
    public class GetMutualista : GetObject<Mutualista>
    {
        RepositorioMutualista _repo;

        public GetMutualista(RepositorioMutualista repo)
        {
            _repo = repo;
        }

        public Mutualista GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioMutualistaException e) { throw new DeleteMutualistaLAException(e.Message); }
            catch (Exception) { throw new DeleteMutualistaLAException("Se ha producido un error inesperado"); }
        }
    }
}
