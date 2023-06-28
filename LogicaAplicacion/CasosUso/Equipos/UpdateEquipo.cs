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
    public class UpdateEquipo : UpdateObject<Equipo>
    {
        RepositorioEquipo _repo;

        public UpdateEquipo(RepositorioEquipo repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Equipo obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioEquipoException e) { throw new DeleteEquipoLAException(e.Message); }
            catch (Exception)
            {

                throw new UpdateEquipoLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
