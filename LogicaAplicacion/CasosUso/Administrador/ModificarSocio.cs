using LogicaConexion.EntityFramework;
using LogicaNegocio.Entidades;
using LogicaNegocio.ValueObject;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CasosUso.Administrador
{
    public class ModificarSocio
    {
        private RepositorioSocio _repositorioSocio;

        public ModificarSocio(RepositorioSocio repositorioSocio)
        {
            _repositorioSocio = repositorioSocio;
        }

        public void EditSocio(Socio obj)
        {
            try
            {
                _repositorioSocio.Edit(obj);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
