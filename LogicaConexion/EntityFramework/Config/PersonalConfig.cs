using LogicaNegocio.Entidades.Empleados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaConexion.EntityFramework.Config
{
    internal class PersonalConfig : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(e => e.Id).IsUnique();

            builder.OwnsOne(personal => personal.Name).Property(name => name.Data).HasColumnName("Nombre");
            builder.OwnsOne(personal => personal.Apellido).Property(apellido => apellido.Data).HasColumnName("Apellido");
            builder.OwnsOne(personal => personal.Cedula).Property(cedula => cedula.Data).HasColumnName("Cedula");
            builder.OwnsOne(personal => personal.Domicilio).Property(domicilio => domicilio.Calle).HasColumnName("Domicilio");
            builder.OwnsOne(personal => personal.Domicilio).Property(domicilio => domicilio.Nro).HasColumnName("NroPuerta");
            builder.OwnsOne(personal => personal.Domicilio).Property(domicilio => domicilio.Esquina1).HasColumnName("Esquina1");
            builder.OwnsOne(personal => personal.Domicilio).Property(domicilio => domicilio.Esquina2).HasColumnName("Esquina2");
            builder.OwnsOne(personal => personal.Contacto.Telefono1).Property(telefono => telefono.Data).HasColumnName("Telefono1");
            builder.OwnsOne(personal => personal.Contacto.Telefono2).Property(telefono => telefono.Data).HasColumnName("Telefono2");
            builder.OwnsOne(personal => personal.Contacto.Email).Property(email => email.Data).HasColumnName("Email");
            builder.OwnsOne(personal => personal.Horario).Property(horario => horario.Inicio).HasColumnName("HoraInicio");
            builder.OwnsOne(personal => personal.Horario).Property(horario => horario.Fin).HasColumnName("HoraFin");
        }
    }
}
