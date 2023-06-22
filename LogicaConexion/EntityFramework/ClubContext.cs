using Microsoft.EntityFrameworkCore;
using LogicaNegocio.Entidades;
using LogicaConexion.EntityFramework.Config;
using LogicaNegocio.Entidades.Actividades;
using Microsoft.EntityFrameworkCore.Internal;
using LogicaNegocio.Entidades.Empleados;

namespace LogicaConexion.EntityFramework
{
    public class ClubContext :DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Actividad> Actividades {  get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Personal> Empleados { get; set; }


        public ClubContext(DbContextOptions options) : base(options) { }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SocioConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
