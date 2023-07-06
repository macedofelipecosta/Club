using AutoMapper;
using LogicaNegocio.Entidades;
using LogicaNegocio.Entidades.Actividades;
using LogicaNegocio.Entidades.Empleados;
using LogicaNegocio.Entidades.Instalaciones;
using LogicaNegocio.Entidades.Servicios;
using LogicaNegocio.ValueObject;
using WebApi.DTOs;

namespace WebApi.Mapper

{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            //source -> destination
            CreateMap<ActividadDTO, Actividad>()
                .ForMember(actividad => actividad.Nombre, actividadDto => actividadDto.MapFrom(campo => new Nombre(campo.Nombre)))
                .ForMember(actividad => actividad.HorarioId, actividadDto => actividadDto.MapFrom(campo => campo.HorarioId))
                .ForMember(actividad => actividad.ProfesorId, actividadDto => actividadDto.MapFrom(campo => campo.ProfesorId))
                .ForMember(actividad => actividad.SalaId, actividadDto => actividadDto.MapFrom(campo => campo.SalaId));

            CreateMap<AdministradorDTO, Administrador>()
                .ForMember(administrador => administrador.Name, administradorDto => administradorDto.MapFrom(campo => new Nombre(campo.Name)))
                .ForMember(administrador => administrador.Email, administradorDto => administradorDto.MapFrom(campo => new Email(campo.Email)));

            CreateMap<EquipoDTO, Equipo>()
                .ForMember(equipo => equipo.Nombre, equipoDto => equipoDto.MapFrom(campo => new Nombre(campo.Nombre)))
                .ForMember(equipo => equipo.Descripcion, equipoDto => equipoDto.MapFrom(campo => new Observaciones(campo.Descripcion)));

            CreateMap<HigieneDTO, Higiene>()
                .ForMember(higiene => higiene.SalaId, higieneDto => higieneDto.MapFrom(campo => campo.Sala))
                .ForMember(higiene => higiene.Descripcion, higieneDto => higieneDto.MapFrom(campo => new Observaciones(campo.Descripcion)))
                .ForMember(higiene => higiene.PersonalId, higieneDto => higieneDto.MapFrom(campo => campo.PersonalId))
                .ForMember(higiene => higiene.Date, higieneDto => higieneDto.MapFrom(campo => new Fecha(campo.Date)));

            CreateMap<HorarioDTO, Horario>()
                .ForMember(horario => horario.Inicio, horarioDto => horarioDto.MapFrom(campo => campo.Inicio))
                .ForMember(horario => horario.Fin, horarioDto => horarioDto.MapFrom(campo => campo.Fin));

            CreateMap<MantenimientoDTO, Mantenimiento>()
                .ForMember(mantenimiento => mantenimiento.SalaId, mantenimientoDto => mantenimientoDto.MapFrom(campo => campo.SalaId))
                .ForMember(mantenimiento => mantenimiento.EquipoId, mantenimientoDto => mantenimientoDto.MapFrom(campo => campo.EquipoId))
                .ForMember(mantenimiento => mantenimiento.Descripcion, mantenimientoDto => mantenimientoDto.MapFrom(campo => new Observaciones(campo.SalaId)))
                .ForMember(mantenimiento => mantenimiento.TecnicoId, mantenimientoDto => mantenimientoDto.MapFrom(campo => campo.TecnicoId))
                .ForMember(mantenimiento => mantenimiento.Date, mantenimientoDto => mantenimientoDto.MapFrom(campo => new Fecha(campo.Date)));

            CreateMap<MutualistaDTO, Mutualista>()
                .ForMember(mutualista => mutualista.Name, mutualistaDto => mutualistaDto.MapFrom(campo => new Nombre(campo.Name)))
                .ForMember(mutualista => mutualista.Telefono, mutualistaDto => mutualistaDto.MapFrom(campo => new Telefono(campo.Telefono)))
                .ForMember(mutualista => mutualista.Emergencia, mutualistaDto => mutualistaDto.MapFrom(campo => new Emergencia(campo.Emergencia)));

            CreateMap<PersonalDTO, Personal>()
                .ForMember(personal => personal.Name, personalDto => personalDto.MapFrom(campo => new Nombre(campo.Name)))
                .ForMember(personal => personal.Apellido, personalDto => personalDto.MapFrom(campo => new Nombre(campo.Apellido)))
                .ForMember(personal => personal.Cedula, personalDto => personalDto.MapFrom(campo => new Cedula(campo.Cedula)))
                .ForMember(personal => personal.Domicilio, personalDto => personalDto.MapFrom(campo => new Domicilio(campo.Calle, campo.NumeroPuerta, campo.Esquina_1, campo.Esquina_2)))
                .ForMember(personal => personal.Contacto, personalDto => personalDto.MapFrom(campo => new Contacto(new Email(campo.Email), new Telefono(campo.Telefono_1), new Telefono(campo.Telefono_2))))
                .ForMember(personal => personal.HorarioId, personalDto => personalDto.MapFrom(campo => campo.HorarioId));
        }
    }
}
