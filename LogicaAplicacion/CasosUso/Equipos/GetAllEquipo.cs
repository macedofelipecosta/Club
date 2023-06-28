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
    public class GetAllEquipo : GetAllObject<Equipo>
    {
        RepositorioEquipo _repo;

        public GetAllEquipo(RepositorioEquipo repo)
        {
            _repo = repo;
        }

        public IEnumerable<Equipo> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioEquipoException e) { throw new DeleteEquipoLAException(e.Message); }
            catch (Exception)
            {

                throw new GetAllEquipoLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
