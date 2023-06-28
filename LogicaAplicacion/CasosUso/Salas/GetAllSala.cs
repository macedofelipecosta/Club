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
    public class GetAllSala : GetAllObject<Sala>
    {
        RepositorioSala _repo;

        public GetAllSala(RepositorioSala repo)
        {
            _repo = repo;
        }

        public IEnumerable<Sala> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioSalaException e) { throw new GetAllSalaLAException(e.Message); }
            catch (Exception) { throw new GetAllSalaLAException("Se ha producido un error inesperado!"); }
        }
    }
}
