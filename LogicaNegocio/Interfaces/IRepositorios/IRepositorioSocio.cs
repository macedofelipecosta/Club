using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioSocio : IRepositorio<Socio>
    {
        public void Add(Socio obj);

        public void Delete(Socio obj);

        public Socio Get(int id);

        public IEnumerable<Socio> GetAll();

        public void Update(Socio obj);
    }
}
