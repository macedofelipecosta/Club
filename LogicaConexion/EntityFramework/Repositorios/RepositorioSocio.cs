using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.IRepositorios;
using LogicaNegocio.ValueObject;
using Microsoft.IdentityModel.Tokens;
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
                if (obj == null) { throw new ArgumentNullException("No se ha recibido un socio para agregar a la base de datos!"); }
                _context.Socios.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e){throw new RepositorioSocioException(e.Message);}
            catch (Exception) { throw new RepositorioSocioException("Ha ocurrido un error inesperado!"); }
        }

        public void Update(Socio obj)
        {
            try
            {
                var socio = Get(obj.Id);
                if (obj.Nombre.Data != null) obj.Nombre.Data = socio.Nombre.Data;
                if (obj.Apellido.Data != null) obj.Apellido.Data = socio.Apellido.Data;
                if (obj.Email.Data != null) obj.Email.Data = socio.Email.Data;
                if (obj.Cedula.Data != null) obj.Cedula.Data = socio.Cedula.Data;
                if (obj.Mutualista != null) obj.Mutualista.Id = socio.Mutualista.Id;
                if (obj.Domicilio.Calle != null) obj.Domicilio.Calle = socio.Domicilio.Calle;
                if (obj.Domicilio.Nro != 0) obj.Domicilio.Nro = socio.Domicilio.Nro;
                if (obj.Domicilio.Esquina1 != null) obj.Domicilio.Esquina1 = socio.Domicilio.Esquina1;
                if (obj.Domicilio.Esquina2 != null) obj.Domicilio.Esquina2 = socio.Domicilio.Esquina2;

                _context.Socios.Update(socio);
                _context.SaveChanges();
            }
            catch (RepositorioSocioException e) { throw new RepositorioSocioException(e.Message); }
            catch (Exception) { throw new RepositorioSocioException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Socio obj)
        {
            try
            {
                var socio = Get(obj.Id);
                _context.Socios.Remove(socio);
                _context.SaveChanges();
            }
            catch (RepositorioSocioException e) { throw new RepositorioSocioException(e.Message); }
            catch (Exception) { throw new RepositorioSocioException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Socio> GetAll()
        {
            try
            {
                var socios=_context.Socios.ToList();
                if (socios.IsNullOrEmpty()) { throw new InvalidOperationException("No se han encontrado socios en la base de datos!"); }
                return socios;
            }
            catch (InvalidOperationException e) { throw new RepositorioSocioException(e.Message); }
            catch (Exception) { throw new RepositorioSocioException("Ha ocurrido un error inesperado!"); }

        }

        public Socio Get(int id)
        {
            try
            {
                var socio = _context.Socios.FirstOrDefault(x => x.Id == id);
                if (socio == null){ throw new InvalidOperationException("No se ha encontrado el socio buscado"); }
                return socio;
            }
            catch (InvalidOperationException e) { throw new RepositorioSocioException(e.Message); }
            catch (Exception) { throw new RepositorioSocioException("Ha ocurrido un error inesperado!"); }
        }


    }
}
