using LogicaNegocio.Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public class IRepositorioPersonal : IRepositorio<Personal>
    {
        public void Add(Personal obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Personal obj)
        {
            throw new NotImplementedException();
        }

        public Personal Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Personal> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Personal obj)
        {
            throw new NotImplementedException();
        }
    }
}
