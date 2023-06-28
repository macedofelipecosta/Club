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
    public class UpdateAdministrador : UpdateObject<Administrador>
    {
        RepositorioAdministrador _repo;

        public UpdateAdministrador(RepositorioAdministrador repo)
        {
            _repo = repo;
        }

        public void UpdateObj(Administrador obj)
        {
            try
            {
                _repo.Update(obj);
            }
            catch (Exception)
            {

                throw new UpdateAdministradorLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
