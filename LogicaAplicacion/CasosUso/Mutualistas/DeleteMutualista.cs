using LogicaAplicacion.Exceptions.Mutualista;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Mutualistas
{
    public class DeleteMutualista : DeleteObject<Mutualista>
    {
        RepositorioMutualista _repo;

        public DeleteMutualista(RepositorioMutualista repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Mutualista obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioMutualistaException e) { throw new DeleteMutualistaLAException(e.Message); }
            catch (Exception) { throw new DeleteMutualistaLAException("Se ha producido un error inesperado"); }
        }
    }
}
