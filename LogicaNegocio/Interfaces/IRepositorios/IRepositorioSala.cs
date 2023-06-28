using LogicaNegocio.Entidades.Instalaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioSala : IRepositorio<Sala>
    {
        public void Add(Sala obj);

        public void Delete(Sala obj);

        public Sala Get(int id);

        public IEnumerable<Sala> GetAll();

        public void Update(Sala obj);
    }
}
