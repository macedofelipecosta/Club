using LogicaAplicacion.Exceptions.Actividades;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Actividades
{
    public class GetActividad:GetObject<Actividad>
    {
        RepositorioActividad _repo;

        public GetActividad(RepositorioActividad repo)
        {
            _repo = repo;
        }

        public Actividad GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioActividadException e) { throw new GetActividadLAException(e.Message); }
            catch (Exception){throw new GetActividadLAException("Ha ocurrido un error ineseperado!");}
        }
    }
}
