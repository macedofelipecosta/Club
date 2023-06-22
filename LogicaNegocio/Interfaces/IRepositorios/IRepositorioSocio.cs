using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.Entidades;
using LogicaNegocio.Entidades.Instalaciones;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioSocio : IRepositorio<Socio>
    {
        public void Add(Socio obj);
        public void Update(Socio obj);
        public void Delete(Socio obj);
        public void Get(int id);
        public IEnumerable<Socio> GetAll();
    }
}
