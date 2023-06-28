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
    public class GetAllHorario : GetAllObject<Horario>
    {
        RepositorioHorario _repo;

        public GetAllHorario(RepositorioHorario repo)
        {
            _repo = repo;
        }

        public IEnumerable<Horario> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioHorarioException e) { throw new GetAllHorariosLAException(e.Message); }
            catch (Exception){throw new GetAllHorariosLAException("Ha ocurrido un error inesperado");}
        }
    }
}
