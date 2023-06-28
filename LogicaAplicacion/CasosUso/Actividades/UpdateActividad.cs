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
    public class UpdateActividad : UpdateObject<Actividad>
    {
        RepositorioActividad _repo;

        public UpdateActividad(RepositorioActividad repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Actividad obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (Exception)
            {
                throw new UpdateActividadLAException("Ha ocurrido un error inesperado, Logica Aplicacion Actividades");
            }
        }
    }
}
