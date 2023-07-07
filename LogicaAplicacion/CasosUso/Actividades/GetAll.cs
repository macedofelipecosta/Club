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
    public class GetAll: GetAllObject<Actividad>
    {
        RepositorioActividad _repo;

        public GetAll(RepositorioActividad repo)
        {
            _repo = repo;
        }

        public IEnumerable<Actividad> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioActividadException e) { throw new GetAllActividadesLAException(e.Message); }
            catch (Exception) {throw new GetAllActividadesLAException("Ocurrio un error inesperado, Logica aplicacion Actividades"); }
                
            
        }
    }
}
