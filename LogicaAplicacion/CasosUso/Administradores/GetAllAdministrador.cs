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
    public class GetAllAdministrador : GetAllObject<Administrador>
    {
        RepositorioAdministrador _repo;

        public GetAllAdministrador(RepositorioAdministrador repo)
        {
            _repo = repo;
        }

        public IEnumerable<Administrador> GetAllObj()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (Exception)
            {
                throw new GetAllAdministradoresLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
