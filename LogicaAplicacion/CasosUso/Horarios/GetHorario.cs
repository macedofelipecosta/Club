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
    public class GetHorario : GetObject<Horario>
    {
        RepositorioHorario _repo;

        public GetHorario(RepositorioHorario repo)
        {
            _repo = repo;
        }

        public Horario GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioHorarioException e) { throw new GetAllHorariosLAException(e.Message); }
            catch (Exception) { throw new GetAllHorariosLAException("Ha ocurrido un error inesperado"); }
        }
    }
}
