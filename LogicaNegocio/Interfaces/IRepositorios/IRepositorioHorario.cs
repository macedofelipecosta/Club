using LogicaNegocio.Entidades.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioHorario : IRepositorio<Horario>
    {
        public void Add(Horario obj);

        public void Delete(Horario obj);
        
        public Horario Get(int id);

        public IEnumerable<Horario> GetAll();

        public void Update(Horario obj);
    }
}
