using LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Config
{
    internal class HigieneConfig : IEntityTypeConfiguration<Higiene>
    {
        public void Configure(EntityTypeBuilder<Higiene> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(x => x.Id);

            builder.OwnsOne(higiene=>higiene.Sala).Property(x=>x.Id).HasColumnName("SalaId");
            builder.OwnsOne(higiene => higiene.Limpieza).Property(x => x.Id).HasColumnName("LimpiadorId");
            builder.OwnsOne(higiene => higiene.Descripcion).Property(x => x.Data).HasColumnName("Descripcion");
            builder.OwnsOne(higiene => higiene.Date).Property(x => x.Data).HasColumnName("Fecha");
        }
    }
}
