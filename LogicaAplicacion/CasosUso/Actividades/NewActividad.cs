using LogicaAplicacion.Exceptions.Actividades;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Actividades
{
    public class NewActividad : NewObject<Actividad>
    {
        RepositorioActividad _repo;

        public NewActividad(RepositorioActividad repo)
        {
            _repo = repo;
        }

        public void NewObj(Actividad obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (Exception)
            {

                throw new NewActividadLAException("Ha ocurrido un error inesperado, Logica aplicacion Actividades");
            }
        }
    }
}
