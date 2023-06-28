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
    public class NewSala : NewObject<Sala>
    {
        RepositorioSala _repo;

        public NewSala(RepositorioSala repo)
        {
            _repo = repo;
        }

        public void NewObj(Sala obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (RepositorioSalaException e) { throw new NewSalaLAException(e.Message); }
            catch (Exception) { throw new NewSalaLAException("Se ha producido un error inesperado!"); }
        }
    }
}
