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
    public class DeleteSocio : DeleteObject<Socio>
    {
        RepositorioSocio _repo;

        public DeleteSocio(RepositorioSocio repo)
        {
            _repo = repo;
        }

        public void DeleteObj(Socio obj)
        {
            try
            {
                _repo.Delete(obj);
            }
            catch (RepositorioSocioException e) { throw new DeleteSocioLAException(e.Message); }
            catch (Exception) { throw new DeleteSocioLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
