using LogicaNegocio.Entidades.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioHigiene:IRepositorio<Higiene>
    {
        public void Add(Higiene obj);

        public void Delete(Higiene obj);

        public Higiene Get(int id);

        public IEnumerable<Higiene> GetAll();

        public void Update(Higiene obj);
    }
}
