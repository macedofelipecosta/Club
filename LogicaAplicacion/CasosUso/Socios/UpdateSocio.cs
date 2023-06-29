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
    public class UpdateSocio : UpdateObject<Socio>
    {
        RepositorioSocio _repo;
        public UpdateSocio(RepositorioSocio repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Socio obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (RepositorioSocioException e) { throw new UpdateSocioLAException(e.Message); }
            catch (Exception) { throw new UpdateSocioLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
