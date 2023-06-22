using LogicaNegocio.Entidades;
using LogicaNegocio.ValueObject;
using Microsoft.EntityFrameworkCore;


namespace LogicaConexion.EntityFramework.Config
{
    internal class SocioConfig : IEntityTypeConfiguration<Socio>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Socio> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey("Id");
            entityTypeBuilder.HasIndex(e => e.Id).IsUnique();

            entityTypeBuilder.OwnsOne(socio => socio.Cedula).Property(Cedula => Cedula.Data).HasColumnName("Cedula");
            entityTypeBuilder.OwnsOne(socio => socio.Nombre).Property(Nombre => Nombre.Data).HasColumnName("Nombre");
            entityTypeBuilder.OwnsOne(socio => socio.Apellido).Property(Apellido => Apellido.Data).HasColumnName("Apellido");
            entityTypeBuilder.OwnsOne(socio => socio.Nacimiento).Property(Nacimiento => Nacimiento.Data).HasColumnName("Nacimiento");
            entityTypeBuilder.OwnsOne(socio => socio.Edad).Property(Edad => Edad.Data).HasColumnName("Edad");
            entityTypeBuilder.OwnsOne(socio => socio.Mutualista).Property(Mutualista => Mutualista.Id).HasColumnName("Mutualista");
            entityTypeBuilder.OwnsOne(socio => socio.Domicilio).Property(Domicilio => Domicilio.Data).HasColumnName("Domicilio");
            entityTypeBuilder.OwnsOne(socio => socio.Email).Property(Email => Email.Data).HasColumnName("Email");
            entityTypeBuilder.OwnsOne(socio => socio.Contacto).Property(Contacto => Contacto.Telefono1).HasColumnName("Contacto");
            entityTypeBuilder.OwnsOne(socio => socio.Registro).Property(Registro => Registro.Data).HasColumnName("Registro");
            entityTypeBuilder.OwnsOne(socio => socio.Observaciones).Property(Observaciones => Observaciones.Data).HasColumnName("Observaciones");

        }
    }
}
