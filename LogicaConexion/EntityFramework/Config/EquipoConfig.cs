using LogicaNegocio.Entidades.Instalaciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Config
{
    internal class EquipoConfig : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(e => e.Id).IsUnique();

            builder.OwnsOne(equipo => equipo.Nombre).Property(name => name.Data).HasColumnName("Nombre");
            builder.OwnsOne(equipo => equipo.Descripcion).Property(descripcion => descripcion.Data).HasColumnName("Descripcion");
        }
    }
}
