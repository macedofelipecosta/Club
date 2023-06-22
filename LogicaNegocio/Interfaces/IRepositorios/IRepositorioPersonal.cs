using LogicaNegocio.Entidades;
using LogicaNegocio.Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioPersonal : IRepositorio<Personal>
    {
        public void Add(Personal obj);
        public void Update(Personal obj);
        public void Delete(Personal obj);
        public void Get(int id);
        public IEnumerable<Personal> GetAll();
    }
}
