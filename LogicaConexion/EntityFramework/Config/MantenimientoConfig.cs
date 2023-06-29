using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Config
{
    internal class MantenimientoConfig : IEntityTypeConfiguration<Mantenimiento>
    {
        public void Configure(EntityTypeBuilder<Mantenimiento> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(x => x.Id).IsUnique();

            builder.OwnsOne(mantenimiento => mantenimiento.Sala).Property(x => x.Id).HasColumnName("SalaId");
            builder.OwnsOne(mantenimiento => mantenimiento.Equipo).Property(x => x.Id).HasColumnName("EquipoId");
            builder.OwnsOne(mantenimiento => mantenimiento.Descripcion).Property(x => x.Data).HasColumnName("Descripcion");
            builder.OwnsOne(mantenimiento => mantenimiento.Tecnico).Property(x => x.Id).HasColumnName("TecnicoId");
            builder.OwnsOne(mantenimiento => mantenimiento.Date).Property(x => x.Data).HasColumnName("FechaRealizado");
        }
    }
}
