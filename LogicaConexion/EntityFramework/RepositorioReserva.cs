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

namespace LogicaConexion.EntityFramework
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
                _context.Reservas.Add(obj);
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido agregar la reserva!");
            }
        }
        public void Remove(int numeroReserva)
        {
            try
            {
                var reserva = GetById(numeroReserva);
                _context.Remove(reserva);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }
        }
        public void Edit(int numeroReserva, Actividad actividad, Sala sala, DateTime fecha)
        {
            try
            {
                var reserva = GetById(numeroReserva);
                reserva.Actividad = actividad;
                reserva.Sala = sala;
                reserva.Fecha = fecha;

                _context.Reservas.Update(reserva);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Reserva GetById(int numeroReserva)
        {
            try
            {
                var reserva = _context.Reservas.FirstOrDefault(X => X.NumeroReserva == numeroReserva);
                if (reserva == null) throw new Exception("No se han encontrado reservas con este número!");
                return reserva;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public IEnumerable<Reserva> GetAll()
        {
            try
            {
                var list = _context.Reservas.ToList();
                if (list.IsNullOrEmpty()) throw new Exception("No se han encontrado reservas!");
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
