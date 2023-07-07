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
            //dto->objeto
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
                .ForMember(higiene => higiene.SalaId, higieneDto => higieneDto.MapFrom(campo => campo.SalaId))
                .ForMember(higiene => higiene.Descripcion, higieneDto => higieneDto.MapFrom(campo => new Observaciones(campo.Descripcion)))
                .ForMember(higiene => higiene.PersonalId, higieneDto => higieneDto.MapFrom(campo => campo.PersonalId))
                .ForMember(higiene => higiene.Date, higieneDto => higieneDto.MapFrom(campo => new Fecha(campo.Date)));

            CreateMap<HorarioDTO, Horario>()
                .ForMember(horario => horario.Inicio, horarioDto => horarioDto.MapFrom(campo => campo.Inicio))
                .ForMember(horario => horario.Fin, horarioDto => horarioDto.MapFrom(campo => campo.Fin));

            CreateMap<MantenimientoDTO, Mantenimiento>()
                .ForMember(mantenimiento => mantenimiento.SalaId, mantenimientoDto => mantenimientoDto.MapFrom(campo => campo.SalaId))
                .ForMember(mantenimiento => mantenimiento.EquipoId, mantenimientoDto => mantenimientoDto.MapFrom(campo => campo.EquipoId))
                .ForMember(mantenimiento => mantenimiento.Descripcion, mantenimientoDto => mantenimientoDto.MapFrom(campo => new Observaciones(campo.Descripcion)))
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
                .ForMember(personal => personal.Horario, personalDto => personalDto.MapFrom(campo => campo.HorarioId));

            CreateMap<ReservaDTO, Reserva>()
                .ForMember(reserva => reserva.SocioId, reservaDto => reservaDto.MapFrom(campo => campo.SocioId))
                .ForMember(reserva => reserva.ActividadId, reservaDto => reservaDto.MapFrom(campo => campo.ActividadId))
                .ForMember(reserva => reserva.SalaId, reservaDto => reservaDto.MapFrom(campo => campo.SalaId))
                .ForMember(reserva => reserva.Fecha, reservaDto => reservaDto.MapFrom(campo => new Fecha(campo.Fecha)));

            CreateMap<SalaDTO, Sala>()
                .ForMember(sala => sala.Nombre, salaDto => salaDto.MapFrom(campo => new Nombre(campo.Nombre)))
                .ForMember(sala => sala.Descripcion, salaDto => salaDto.MapFrom(campo => new Observaciones(campo.Descripcion)));

            CreateMap<SocioDTO, Socio>()
                .ForMember(socio => socio.Cedula, socioDto => socioDto.MapFrom(campo => new Cedula(campo.Cedula)))
                .ForMember(socio => socio.Nombre, socioDto => socioDto.MapFrom(campo => new Nombre(campo.Nombre)))
                .ForMember(socio => socio.Apellido, socioDto => socioDto.MapFrom(campo => new Nombre(campo.Apellido)))
                .ForMember(socio => socio.Nacimiento, socioDto => socioDto.MapFrom(campo => new Fecha(campo.Nacimiento)))
                .ForMember(socio => socio.MutualistaId, socioDto => socioDto.MapFrom(campo => campo.MutualistaId))
                .ForMember(socio => socio.Domicilio, socioDto => socioDto.MapFrom(campo => new Domicilio(campo.Calle, campo.Numero, campo.Esquina_1, campo.Esquina_2)))
                .ForMember(socio => socio.Contacto, socioDto => socioDto.MapFrom(campo => new Contacto(new Email(campo.Email), new Telefono(campo.Telefono_1), new Telefono(campo.Telefono_2))));

            //objeto -> dto
            //source -> destination
            CreateMap<Actividad, ActividadDTO>()
                .ForMember(actividadDto => actividadDto.Nombre, actividad => actividad.MapFrom(campo => campo.Nombre.Data))
                .ForMember(actividadDto => actividadDto.HorarioId, actividad => actividad.MapFrom(campo => campo.HorarioId))
                .ForMember(actividadDto => actividadDto.ProfesorId, actividad => actividad.MapFrom(campo => campo.ProfesorId))
                .ForMember(actividadDto => actividadDto.SalaId, actividad => actividad.MapFrom(campo => campo.SalaId));

            CreateMap<Administrador, AdministradorDTO>()
                .ForMember(administradorDto => administradorDto.Name, administrador => administrador.MapFrom(campo => campo.Name.Data))
                .ForMember(administradorDto => administradorDto.Email, administrador => administrador.MapFrom(campo => campo.Email.Data));

            CreateMap<Equipo, EquipoDTO>()
                .ForMember(equipoDto => equipoDto.Nombre, equipo => equipo.MapFrom(campo => campo.Nombre.Data))
                .ForMember(equipoDto => equipoDto.Descripcion, equipo => equipo.MapFrom(campo => campo.Descripcion.Data));

            CreateMap<Higiene, HigieneDTO>()
                .ForMember(higieneDto => higieneDto.SalaId, higiene => higiene.MapFrom(campo => campo.SalaId))
                .ForMember(higieneDto => higieneDto.Descripcion, higiene => higiene.MapFrom(campo => (campo.Descripcion.Data)))
                .ForMember(higieneDto => higieneDto.PersonalId, higiene => higiene.MapFrom(campo => campo.PersonalId))
                .ForMember(higieneDto => higieneDto.Date, higiene => higiene.MapFrom(campo => (campo.Date.Data)));

            CreateMap<Horario, HorarioDTO>()
                .ForMember(horarioDto => horarioDto.Inicio, horario => horario.MapFrom(campo => campo.Inicio))
                .ForMember(horarioDto => horarioDto.Fin, horario => horario.MapFrom(campo => campo.Fin));

            CreateMap<Mantenimiento, MantenimientoDTO>()
                .ForMember(mantenimientoDto => mantenimientoDto.SalaId, mantenimiento => mantenimiento.MapFrom(campo => campo.SalaId))
                .ForMember(mantenimientoDto => mantenimientoDto.EquipoId, mantenimiento => mantenimiento.MapFrom(campo => campo.EquipoId))
                .ForMember(mantenimientoDto => mantenimientoDto.Descripcion, mantenimiento => mantenimiento.MapFrom(campo => (campo.Descripcion.Data)))
                .ForMember(mantenimientoDto => mantenimientoDto.TecnicoId, mantenimiento => mantenimiento.MapFrom(campo => campo.TecnicoId))
                .ForMember(mantenimientoDto => mantenimientoDto.Date, mantenimiento => mantenimiento.MapFrom(campo => (campo.Date.Data)));

            CreateMap<Mutualista, MutualistaDTO>()
                .ForMember(mutualistaDto => mutualistaDto.Name, mutualista => mutualista.MapFrom(campo => (campo.Name.Data)))
                .ForMember(mutualistaDto => mutualistaDto.Telefono, mutualista => mutualista.MapFrom(campo => (campo.Telefono.Data)))
                .ForMember(mutualistaDto => mutualistaDto.Emergencia, mutualista => mutualista.MapFrom(campo => (campo.Emergencia.Data)));

            CreateMap<Personal, PersonalDTO>()
                .ForMember(personalDto => personalDto.Name, personal => personal.MapFrom(campo => (campo.Name.Data)))
                .ForMember(personalDto => personalDto.Apellido, personal => personal.MapFrom(campo => (campo.Apellido.Data)))
                .ForMember(personalDto => personalDto.Cedula, personal => personal.MapFrom(campo => (campo.Cedula.Data)))
                .ForMember(personalDto => personalDto.Calle, personal => personal.MapFrom(campo => campo.Domicilio.Calle))
                .ForMember(personalDto => personalDto.NumeroPuerta, personal => personal.MapFrom(campo => campo.Domicilio.Nro))
                .ForMember(personalDto => personalDto.Esquina_1, personal => personal.MapFrom(campo => campo.Domicilio.Esquina1))
                .ForMember(personalDto => personalDto.Esquina_2, personal => personal.MapFrom(campo => campo.Domicilio.Esquina2))
                .ForMember(personalDto => personalDto.Email, personal => personal.MapFrom(campo => campo.Contacto.Email.Data))
                .ForMember(personalDto => personalDto.Telefono_1, personal => personal.MapFrom(campo => campo.Contacto.Telefono1.Data))
                .ForMember(personalDto => personalDto.Telefono_2, personal => personal.MapFrom(campo => campo.Contacto.Telefono2.Data))
                .ForMember(personalDto => personalDto.HorarioId, personal => personal.MapFrom(campo => campo.Horario.Id));

            CreateMap<Reserva, ReservaDTO>()
                .ForMember(reservaDto => reservaDto.SocioId, reserva => reserva.MapFrom(campo => campo.SocioId))
                .ForMember(reservaDto => reservaDto.ActividadId, reserva => reserva.MapFrom(campo => campo.ActividadId))
                .ForMember(reservaDto => reservaDto.SalaId, reserva => reserva.MapFrom(campo => campo.SalaId))
                .ForMember(reservaDto => reservaDto.Fecha, reserva => reserva.MapFrom(campo => campo.Fecha));

            CreateMap<Sala, SalaDTO>()
                .ForMember(salaDto => salaDto.Nombre, sala => sala.MapFrom(campo => campo.Nombre.Data))
                .ForMember(salaDto => salaDto.Descripcion, sala => sala.MapFrom(campo => campo.Descripcion.Data));

            CreateMap<Socio, SocioDTO>()
                .ForMember(socioDto => socioDto.Cedula, socio => socio.MapFrom(campo => (campo.Cedula.Data)))
                .ForMember(socioDto => socioDto.Nombre, socio => socio.MapFrom(campo => (campo.Nombre.Data)))
                .ForMember(socioDto => socioDto.Apellido, socio => socio.MapFrom(campo => (campo.Apellido.Data)))
                .ForMember(socioDto => socioDto.Nacimiento, socio => socio.MapFrom(campo => (campo.Nacimiento.Data)))
                .ForMember(socioDto => socioDto.MutualistaId, socio => socio.MapFrom(campo => campo.MutualistaId))
                .ForMember(socioDto => socioDto.Calle, socio => socio.MapFrom(campo => campo.Domicilio.Calle))
                .ForMember(socioDto => socioDto.Numero, socio => socio.MapFrom(campo => campo.Domicilio.Nro))
                .ForMember(socioDto => socioDto.Esquina_1, socio => socio.MapFrom(campo => campo.Domicilio.Esquina1))
                .ForMember(socioDto => socioDto.Esquina_2, socio => socio.MapFrom(campo => campo.Domicilio.Esquina2))
                .ForMember(socioDto => socioDto.Email, socio => socio.MapFrom(campo => campo.Contacto.Email.Data))
                .ForMember(socioDto => socioDto.Telefono_1, socio => socio.MapFrom(campo => campo.Contacto.Telefono1.Data))
                .ForMember(socioDto => socioDto.Telefono_2, socio => socio.MapFrom(campo => campo.Contacto.Telefono2.Data));
        }
    }
}
