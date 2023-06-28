using LogicaNegocio.Entidades.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioActividad : IRepositorio<Actividad>
    {
        public void Add(Actividad obj) ;

        public void Delete(Actividad obj) ;

        public Actividad Get(int id);

        public IEnumerable<Actividad> GetAll();

        public void Update(Actividad obj) ;
    }
}
