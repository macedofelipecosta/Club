﻿using LogicaNegocio.Entidades.Actividades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.IRepositorios
{
    public interface IRepositorioReserva : IRepositorio<Reserva>
    {
        public void Add(Reserva obj);

        public void Delete(Reserva obj);

        public Reserva Get(int id);

        public IEnumerable<Reserva> GetAll();

        public void Update(Reserva obj);
    }
}
