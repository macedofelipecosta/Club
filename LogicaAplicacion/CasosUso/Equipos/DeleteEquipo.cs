using LogicaAplicacion.Exceptions.Equipos;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Instalaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Equipos
{
    public class DeleteEquipo : DeleteObject<Equipo>
    {
        RepositorioEquipo _repo;

        public DeleteEquipo(RepositorioEquipo repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Equipo obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioEquipoException e) { throw new DeleteEquipoLAException(e.Message); }
            catch (Exception)
            {

                throw new DeleteEquipoLAException("Ha ocurrido un error inesperado");
            }
        }
    }
}
