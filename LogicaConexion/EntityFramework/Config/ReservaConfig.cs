using LogicaNegocio.Entidades.Actividades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Config
{
    internal class ReservaConfig : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(e => e.Id).IsUnique();

            builder.OwnsOne(reserva => reserva.Socio).Property(socio => socio.Id).HasColumnName("Socio");
            builder.OwnsOne(reserva => reserva.Actividad).Property(actividad => actividad.Id).HasColumnName("Actividad");
            builder.OwnsOne(reserva => reserva.Sala).Property(sala => sala.Id).HasColumnName("Sala");

        }
    }
}
