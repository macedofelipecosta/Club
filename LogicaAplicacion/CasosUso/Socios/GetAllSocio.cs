using LogicaAplicacion.Exceptions.Socios;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Socios
{
    public class GetAllSocio : GetAllObject<Socio>
    {
        RepositorioSocio _repo;

        public GetAllSocio(RepositorioSocio repo)
        {
            _repo = repo;
        }

        public IEnumerable<Socio> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (RepositorioSocioException e) { throw new GetAllSocioLAException(e.Message); }
            catch (Exception) { throw new GetAllSocioLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
