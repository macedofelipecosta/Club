﻿using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Interfaces.IRepositorios;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Repositorios
{
    public class RepositorioHorario : IRepositorioHorario
    {
        private ClubContext _context;
        public RepositorioHorario(ClubContext context)
        {
            _context = context;
        }

        public void Add(Horario obj)
        {
            try
            {
                _context.Horarios.Add(obj);
            }
            catch (Exception)
            {
                throw new RepositorioHorarioException("No se ha podido crear el horario!");
            }
        }
        public void Delete(Horario obj)
        {
            try
            {
                var horario = Get(obj.Id);
                _context.Horarios.Remove(horario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw new RepositorioHorarioException(e.Message);
            }

        }
        public void Update(Horario obj)
        {
            try
            {
                var horario = Get(obj.Id);
                horario.Inicio = obj.Inicio;
                horario.Fin = obj.Fin;
                _context.Horarios.Update(horario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new RepositorioHorarioException(e.Message);
            }
        }
        public Horario Get(int id)
        {
            try
            {
                var horario = _context.Horarios.FirstOrDefault(x => x.Id == id);
                if (horario == null) throw new KeyNotFoundException("No se ha encnotrado el horario!");
                return horario;
            }
            catch (Exception e)
            {
                throw new RepositorioHorarioException(e.Message);
            }
        }
        public IEnumerable<Horario> GetAll()
        {
            try
            {
                var horarios = _context.Horarios.ToList();
                if (horarios.IsNullOrEmpty()) throw new Exception("No se han encontrado horarios!");
                return horarios;
            }
            catch (Exception e)
            {
                throw new RepositorioHorarioException(e.Message);
            }
        }


    }
}
