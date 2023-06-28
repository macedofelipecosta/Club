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
    public class UpdateMutualista : UpdateObject<Mutualista>
    {
        RepositorioMutualista _repo;

        public UpdateMutualista(RepositorioMutualista repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Mutualista obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioMutualistaException e) { throw new DeleteMutualistaLAException(e.Message); }
            catch (Exception) { throw new DeleteMutualistaLAException("Se ha producido un error inesperado"); }
        }
    }
}
