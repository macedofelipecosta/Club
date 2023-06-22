using LogicaConexion.EntityFramework;
using LogicaNegocio.Entidades;
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

        public void EditSocio(int id, string nombre, string apellido, string email,
                            string cedula, Mutualista mutualista, string domicilio, DateTime nacimiento)
        {
            try
            {
                _repositorioSocio.Edit(id,nombre,apellido,email,cedula,mutualista,domicilio,nacimiento);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
