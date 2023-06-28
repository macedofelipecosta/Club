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
    public class NewEquipo : NewObject<Equipo>
    {
        RepositorioEquipo _repo;

        public NewEquipo(RepositorioEquipo repo)
        {
            _repo = repo;
        }

        public void NewObj(Equipo obj)
        {
            try
            {
                _repo.Add(obj);
            }
            catch (Exception)
            {

                throw new NewEquipoLAException ("Ha ocurrido un error inesperado");
            }
        }
    }
}
