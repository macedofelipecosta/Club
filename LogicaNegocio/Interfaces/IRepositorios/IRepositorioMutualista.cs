using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioMutualista : IRepositorio<Mutualista>
    {
        public void Add(Mutualista obj);
        public void Update(Mutualista obj);
        public void Delete(Mutualista obj);
        public void Get(int id);
        public IEnumerable<Mutualista> GetAll();
    }
}
