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
    internal class SalaConfig : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(e => e.Id).IsUnique();

            builder.OwnsOne(sala => sala.Nombre).Property(name => name.Data).HasColumnName("Nombre");
            builder.OwnsOne(sala => sala.Descripcion).Property(descripcion => descripcion.Data).HasColumnName("Descripcion");
            
        }
    }
}
