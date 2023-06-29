using Microsoft.EntityFrameworkCore;
using LogicaNegocio.Entidades;
using LogicaConexion.EntityFramework.Config;
using LogicaNegocio.Entidades.Actividades;
using Microsoft.EntityFrameworkCore.Internal;
using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Entidades.Servicios;

namespace LogicaConexion.EntityFramework
{
    public class ClubContext :DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Actividad> Actividades {  get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Personal> Empleados { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Mutualista> Mutualistas { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<Higiene> Higienes { get; set; }


        public ClubContext(DbContextOptions options) : base(options) { }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SocioConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
