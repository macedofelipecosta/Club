using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioReserva : IRepositorioReserva
    {
        private ClubContext _context;
        public RepositorioReserva(ClubContext context)
        {
            _context = context;
        }

        public void Add(Reserva obj)
        {
            try
            {
                if (obj == null) { throw new ArgumentNullException("No se ha recibido ningun objeto para agregar a la base de datos!"); }
                _context.Reservas.Add(obj);
                _context.SaveChanges();
            }
            catch (ArgumentNullException e) { throw new RepositorioReservaException(e.Message); }
            catch (Exception) { throw new RepositorioReservaException("Ha ocurrido un error inesperado!"); }
        }
        public void Delete(Reserva obj)
        {
            try
            {
                var reserva = Get(obj.Id);
                _context.Remove(reserva);
                _context.SaveChanges();
            }
            catch (RepositorioReservaException e) { throw new RepositorioReservaException(e.Message); }
            catch (Exception) { throw new RepositorioReservaException("Ha ocurrido un error inesperado!"); }
        }
        public void Update(Reserva obj)
        {
            try
            {
                var reserva = Get(obj.Id);
                if (obj.Actividad.Id != null) { reserva.Actividad.Id = obj.Actividad.Id; }
                if (obj.Sala.Id != null) { reserva.Sala.Id = obj.Sala.Id;}
                if(obj.Fecha!=null) { reserva.Fecha=obj.Fecha;}
                
                _context.Reservas.Update(reserva);
                _context.SaveChanges();
            }
            catch (RepositorioReservaException e) { throw new RepositorioReservaException(e.Message); }
            catch (Exception) { throw new RepositorioReservaException("Ha ocurrido un error inesperado!"); }
        }
        public Reserva Get(int numeroReserva)
        {
            try
            {
                var reserva = _context.Reservas.FirstOrDefault(X => X.Id == numeroReserva);
                if (reserva == null) throw new InvalidOperationException("No se han encontrado reservas con este número!");
                return reserva;
            }
            catch (InvalidOperationException e){throw new RepositorioReservaException(e.Message);}
            catch (Exception) { throw new RepositorioReservaException("Ha ocurrido un error inesperado!"); }
        }
        public IEnumerable<Reserva> GetAll()
        {
            try
            {
                var list = _context.Reservas.ToList();
                if (list.IsNullOrEmpty()) throw new InvalidOperationException("No se han encontrado reservas en la base de datos!");
                return list;
            }
            catch (InvalidOperationException e) { throw new RepositorioReservaException(e.Message); }
            catch (Exception) { throw new RepositorioReservaException("Ha ocurrido un error inesperado!"); }
        }
    }
}
