using LogicaAplicacion.Exceptions.Actividades;
using LogicaAplicacion.Interfaces;
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
            catch (Exception)
            {
                throw new GetActividadLAException ("Error al obtener actividad, Logica Aplicacion");
            }
        }
    }
}
