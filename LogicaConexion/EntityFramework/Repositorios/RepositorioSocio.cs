using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.IRepositorios;
using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioSocio : IRepositorioSocio
    {
        private ClubContext _context;
        public RepositorioSocio(ClubContext context)
        {
            _context = context;
        }

        public void Add(Socio obj)
        {
            try
            {
                _context.Socios.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Edit(Socio obj)
        {
            try
            {
                var socio = Get(obj.Id);
                if (obj.Nombre.Data == null) socio.Nombre.Data = socio.Nombre.Data;
                if (obj.Apellido.Data == null) socio.Apellido.Data = socio.Apellido.Data;
                if (obj.Email.Data == null) socio.Email.Data = socio.Email.Data;
                if (obj.Cedula.Data == null) socio.Cedula.Data = socio.Cedula.Data;
                if (obj.Mutualista == null) socio.Mutualista.Id = socio.Mutualista.Id;
                if (obj.Domicilio.Data == null) socio.Domicilio.Data = socio.Domicilio.Data;


                socio.Nombre.Data = obj.Nombre.Data;
                socio.Apellido.Data = obj.Apellido.Data;
                socio.Email.Data = obj.Email.Data;
                socio.Cedula.Data = obj.Cedula.Data;
                socio.Mutualista.Id = obj.Mutualista.Id;
                socio.Domicilio.Data = obj.Domicilio.Data;
                socio.Nacimiento.Data = obj.Nacimiento.Data;

                _context.Socios.Update(socio);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }




        public void Delete(Socio obj)
        {
            try
            {
                var socio = Get(obj.Id);
                if (socio == null) throw new Exception($"No se ha podido borrar al socio Nro {obj.Id}");
                _context.Socios.Remove(socio);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Socio> GetAll()
        {
            try
            {
                return _context.Socios.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public Socio Get(int id)
        {
            try
            {
                var socio = _context.Socios.FirstOrDefault(x => x.Id == id);
                if (socio != null)
                {
                    return socio;
                }
                else throw new Exception($"No se ha encontrado al socio Nro {id}!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
