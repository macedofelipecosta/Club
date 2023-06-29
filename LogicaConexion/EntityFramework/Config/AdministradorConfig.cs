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
    internal class AdministradorConfig : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(e => e.Id).IsUnique();

            builder.OwnsOne(administrador => administrador.Name.Data).Property(Name=>Name).HasColumnName("NombreAdmin");
            builder.OwnsOne(administrador => administrador.Email.Data).Property(Email => Email).HasColumnName("EmailAdmin");
            //builder.OwnsOne(administrador => administrador.Identificador).Property(Identificador => Identificador).HasColumnName("EmailAdmin");
        }
    }
}
