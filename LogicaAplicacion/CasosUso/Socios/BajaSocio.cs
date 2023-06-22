using LogicaConexion.EntityFramework;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Socios
{
    public class BajaSocio
    {
        private RepositorioSocio _repositorioSocio;

        public BajaSocio(RepositorioSocio repositorioSocio)
        {
            _repositorioSocio = repositorioSocio;
        }

        public void EliminarSocio(Socio obj)
        {
            _repositorioSocio.Remove(obj.Id);
        }
    }
}
