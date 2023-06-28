using LogicaAplicacion.Exceptions.Equipos;
using LogicaAplicacion.Interfaces;
using LogicaConexion.EntityFramework.Repositorios;
using LogicaNegocio.Entidades.Instalaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Equipos
{
    public class GetEquipo : GetObject<Equipo>
    {
        RepositorioEquipo _repo;

        public GetEquipo(RepositorioEquipo repo)
        {
            _repo = repo;
        }

        public Equipo GetObject(int id)
        {
            try
            {
                return _repo.Get(id);
            }
            catch (Exception)
            {

                throw new GetEquipoLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
