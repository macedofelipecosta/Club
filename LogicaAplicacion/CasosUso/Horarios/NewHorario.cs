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
    public class NewHorario : NewObject<Horario>
    {
        RepositorioHorario _repo;

        public NewHorario(RepositorioHorario repo)
        {
            _repo = repo;
        }

        public void NewObj(Horario obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (RepositorioHorarioException e) { throw new GetAllHorariosLAException(e.Message); }
            catch (Exception) { throw new GetAllHorariosLAException("Ha ocurrido un error inesperado"); }
        }
    }
}
