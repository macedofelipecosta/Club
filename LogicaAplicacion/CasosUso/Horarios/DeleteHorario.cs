using LogicaAplicacion.Exceptions.Horarios;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Horarios
{
    public class DeleteHorario : DeleteObject<Horario>
    {
        RepositorioHorario _repo;

        public DeleteHorario(RepositorioHorario repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Horario obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioHorarioException e) { throw new DeleteHorariosLAException(e.Message); }
            catch (Exception)
            {

                throw new DeleteHorariosLAException("Ha ocurrido un error inesperado");
            }
        }
    }
}
