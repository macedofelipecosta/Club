using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework
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

        public void Edit(int id, string nombre, string apellido, string email,
                            string cedula, Mutualista mutualista, string domicilio, DateTime nacimiento)
        {
            try
            {
                var socio = GetById(id);
                if (nombre == null) nombre = socio.Nombre;
                if (apellido == null) apellido = socio.Apellido;
                if (email == null) email = socio.Email;
                if (cedula == null) cedula = socio.Cedula;
                if (mutualista == null) mutualista = socio.Mutualista;
                if (domicilio == null) domicilio = socio.Domicilio;
                ValidarEdad(nacimiento);

                socio.Nombre = nombre;
                socio.Apellido = apellido;
                socio.Email = email;
                socio.Cedula = cedula;
                socio.Mutualista = mutualista;
                socio.Domicilio = domicilio;
                socio.Nacimiento = nacimiento;

                _context.Socios.Update(socio);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void ValidarEdad(DateTime nacimiento)
        {
            try
            {
                int edad = nacimiento.Year - DateTime.Now.Year;
                if (edad > 110)
                {
                    throw new Exception("La edad no es válida, debe ser menor a 110 años!");
                }
                if (edad<1)
                {
                    throw new Exception("La edad no es válida, debe ser mayor a 1 año!");
                }
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }
        }


        public void Remove(int id)
        {
            try
            {
                var socio = GetById(id);
                if (socio == null) throw new Exception($"No se ha podido borrar al socio Nro {id}");
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
        public Socio GetById(int id)
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
