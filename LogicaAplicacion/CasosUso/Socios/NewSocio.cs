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
    public class NewSocio : NewObject<Socio>
    {
        RepositorioSocio _repo;
        public NewSocio(RepositorioSocio repo)
        {
            _repo = repo;
        }

        public void NewObj(Socio obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (RepositorioSocioException e) { throw new NewSocioLAException(e.Message); }
            catch (Exception) { throw new NewSocioLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
