using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public class IRepositorioAdministrador : IRepositorio<Administrador>
    {
        public void Add(Administrador obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Administrador obj)
        {
            throw new NotImplementedException();
        }

        public Administrador Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Administrador> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Administrador obj)
        {
            throw new NotImplementedException();
        }
    }
}
