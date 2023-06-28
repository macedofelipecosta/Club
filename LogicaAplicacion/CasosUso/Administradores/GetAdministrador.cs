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
    public class GetAdministrador : GetObject<Administrador>
    {
        RepositorioAdministrador _repo;

        public GetAdministrador(RepositorioAdministrador repo)
        {
            _repo = repo;
        }

        public Administrador GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (Exception)
            {

                throw new GetAdministradorLAException("Ha ocurrido un error inesperado");
            }
        }
    }
}
