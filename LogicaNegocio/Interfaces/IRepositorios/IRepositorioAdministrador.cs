using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioAdministrador : IRepositorio<Administrador>
    {
        public void Add(Administrador obj);

        public void Delete(Administrador obj);

        public Administrador Get(int id);

        public IEnumerable<Administrador> GetAll();

        public void Update(Administrador obj);
    }
}
