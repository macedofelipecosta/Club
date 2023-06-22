using LogicaAplicacion.CasosUso.Socios;
using LogicaConexion.EntityFramework;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Socios
{
    public class AltaSocio
    {
        private RepositorioSocio _repositorioSocio;

        public AltaSocio(RepositorioSocio context)
        {
            _repositorioSocio = context;
        }

        public void CrearSocio(Socio obj)
        {
            try
            {
                _repositorioSocio.Add(obj);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            } 
        }

    }
}
