using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Instalaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioEquipo : IRepositorio<Equipo>
    {
        public void Add(Equipo obj);
        public void Update(Equipo obj);
        public void Delete(Equipo obj);
        public void Get(int id);
        public IEnumerable<Equipo> GetAll();
    }
}
