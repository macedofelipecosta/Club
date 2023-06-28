using LogicaAplicacion.Exceptions.Colaboradores;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Colaboradores
{
    public class NewPersonal : NewObject<Personal>
    {
        RepositorioPersonal _repo;

        public NewPersonal(RepositorioPersonal repo)
        {
            _repo = repo;
        }

        public void NewObj(Personal obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (RepositorioPersonalException e) { throw new NewPersonalLAException(e.Message); }
            catch (Exception) { throw new NewPersonalLAException("Ha ocurrido un error inesperado!"); }
        }
    }
}
