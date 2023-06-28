using LogicaAplicacion.Exceptions.Administradores;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Administradores
{
    public class NewAdministrador : NewObject<Administrador>
    {
        RepositorioAdministrador _repo;

        public NewAdministrador(RepositorioAdministrador repo)
        {
            _repo = repo;
        }

        public void NewObj(Administrador obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (Exception)
            {

                throw new NewAdministradorLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
