using LogicaNegocio.Entidades.Actividades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogicaConexion.EntityFramework.Config
{
    internal class ActividadConfig : IEntityTypeConfiguration<Actividad>
    {
        public void Configure(EntityTypeBuilder<Actividad> builder)
        {
            builder.HasKey("Id");
            builder.HasIndex(e => e.Id).IsUnique();

            builder.OwnsOne(actividad => actividad.Nombre).Property(Nombre => Nombre.Data).HasColumnName("NombreActividad");
            builder.OwnsOne(actividad => actividad.Horario).Property(Horario => Horario.Inicio).HasColumnName("HorarioInicio");
            builder.OwnsOne(actividad => actividad.Horario).Property(Horario => Horario.Fin).HasColumnName("HorarioFin");
            builder.OwnsOne(actividad => actividad.Profesor).Property(Profesor => Profesor.Id).HasColumnName("ProfesorId");
            builder.OwnsOne(actividad => actividad.Sala).Property(Sala => Sala.Id).HasColumnName("SalaId");
        }
    }
}
