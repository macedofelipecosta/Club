using LogicaNegocio.Entidades.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioActividad : IRepositorio<Actividad>
    {
        public Actividad Get(int id);
        public void Add(Actividad obj);
        //public void Update(Actividad obj);
        public void Delete(Actividad obj);
        public IEnumerable<Actividad> GetAll();
    }
}
