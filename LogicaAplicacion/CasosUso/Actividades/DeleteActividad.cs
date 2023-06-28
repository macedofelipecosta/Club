using LogicaAplicacion.Exceptions.Actividades;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Actividades;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Actividades
{
    public class DeleteActividad : DeleteObject<Actividad>
    {
        RepositorioActividad _repo;

        public DeleteActividad(RepositorioActividad repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Actividad obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (Exception)
            {

                throw new DeleteActividadLAException ("Error a nivel de LA");
            }
            
        }
    }
}
