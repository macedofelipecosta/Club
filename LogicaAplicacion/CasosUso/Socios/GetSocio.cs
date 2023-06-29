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
    public class GetSocio : GetObject<Socio>
    {
        RepositorioSocio _repo;
        public GetSocio(RepositorioSocio repo)
        {
            _repo = repo;
        }

        public Socio GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (RepositorioSocioException e) { throw new GetSocioLAException(e.Message); }
            catch (Exception) { throw new GetSocioLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
