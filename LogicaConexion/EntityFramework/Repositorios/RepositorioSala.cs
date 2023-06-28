using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioSala : IRepositorioSala
    {
        ClubContext _context;

        public RepositorioSala(ClubContext context)
        {
            _context = context;
        }

        public void Add(Sala obj)
        {
            try
            {
                if (obj == null) { throw new ArgumentNullException("No se ha recibido ninguna sala para agregar a la base de datos!"); }
                _context.Salas.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioSalaException(e.Message); }
            catch (Exception) { throw new RepositorioSalaException("Ha ocurrido un error inesperado!"); }
        }

        public void Delete(Sala obj)
        {
            try
            {
                var sala = Get(obj.Id);
                _context.Salas.Remove(sala);
                _context.SaveChanges();
            }
            catch (RepositorioSalaException e) { throw new RepositorioSalaException(e.Message); }
            catch (Exception) { throw new RepositorioSalaException("Ha ocurrido un error inesperado!"); }
        }

        public Sala Get(int id)
        {
            try
            {
                var sala= _context.Salas.FirstOrDefault(x=> x.Id == id);
                if (sala == null) throw new InvalidOperationException("No se ha encontrado la sala buscada!");
                return sala;
            }
            catch (InvalidOperationException e) { throw new RepositorioSalaException(e.Message); }
            catch (Exception) { throw new RepositorioSalaException("Ha ocurrido un error inesperado!"); }
        }

        public IEnumerable<Sala> GetAll()
        {
            try
            {
                var salas = _context.Salas.ToList();
                if (salas.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado salas en la base de datos!");
                return salas;
            }
            catch (InvalidOperationException e) { throw new RepositorioSalaException(e.Message); }
            catch (Exception) { throw new RepositorioSalaException("Ha ocurrido un error inesperado!"); }
        }

        public void Update(Sala obj)
        {
            try
            {
                var sala = Get(obj.Id);
                if (obj.Nombre.Data != null) { sala.Nombre.Data = obj.Nombre.Data; }
                if (obj.Descripcion.Data != null) { sala.Descripcion.Data=obj.Descripcion.Data;}
                _context.Salas.Update(obj);
                _context.SaveChanges();
            }
            catch (RepositorioSalaException e) { throw new RepositorioSalaException(e.Message); }
            catch (Exception) { throw new RepositorioSalaException("Ha ocurrido un error inesperado!"); }
        }
    }
}
