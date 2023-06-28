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
    public class UpdateSala : UpdateObject<Sala>
    {
        RepositorioSala _repo;

        public UpdateSala(RepositorioSala repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Sala obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioSalaException e) { throw new UpdateSalaLAException(e.Message); }
            catch (Exception) { throw new UpdateSalaLAException("Se ha producido un error inesperado!"); }
        }
    }
}
