using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Entidades.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioMantenimiento:IRepositorio<Mantenimiento>
    {
        public void Add(Mantenimiento obj);

        public void Delete(Mantenimiento obj);

        public Mantenimiento Get(int id);

        public IEnumerable<Mantenimiento> GetAll();

        public void Update(Mantenimiento obj);
    }
}
