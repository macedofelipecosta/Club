using LogicaAplicacion.Exceptions.Salas;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Instalaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Salas
{
    public class DeleteSala : DeleteObject<Sala>
    {
        RepositorioSala _repo;

        public DeleteSala(RepositorioSala repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Sala obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioSalaException e) { throw new DeleteSalaLAException(e.Message); }
            catch (Exception) { throw new DeleteSalaLAException("Se ha producido un error inesperado!"); }
        }
    }
}
