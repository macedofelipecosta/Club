﻿using AutoMapper;
using LogicaAplicacion.CasosUso.Actividades;
using LogicaAplicacion.Exceptions.Actividades;
using LogicaConexion.EntityFramework.Exceptions;
using LogicaNegocio.Entidades.Actividades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApi.DTOs;
using WebApi.Excepciones;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/v1/Actividades")]
    [ApiController]
    public class ActividadesController : ControllerBase
    {
        private IMapper _mapper;
        private DeleteActividad _delete;
        private GetActividad _get;
        private GetAll _getAll;
        private NewActividad _new;
        private UpdateActividad _update;


        public ActividadesController(IMapper mapper, GetActividad get, GetAll getAll,
                                        NewActividad @new, UpdateActividad update)
        {
            _mapper = mapper;
            _get = get;
            _getAll = getAll;
            _new = @new;
            _update = update;
        }






        // GET: api/<ActividadesController>
        [HttpGet("~/Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get(int id)
        {
            try
            {
                ActividadDTO actividadDto = _mapper.Map<ActividadDTO>(_get.GetObject(id));
                if (actividadDto == null) { throw new ActividadesControllerException("No se ha encontrado la actividad!"); }
                return Ok(actividadDto);
            }
            catch (GetActividadLAException e) { throw new ActividadesControllerException(e.Message); }
            catch (ActividadesControllerException e) { throw new ActividadesControllerException(e.Message); }
            catch (Exception) { throw new ActividadesControllerException("Ha ocurrido un error inesperado!"); }
        }

        // GET api/<ActividadesController>/5
        [HttpGet("{id}")]
        public IActionResult GetAll()
        {
            try
            {
                var lista = _getAll.GetAllObj();
                if (lista.IsNullOrEmpty()) throw new ActividadesControllerException("No se han encontrado actividades en la base de datos!");
                List<ActividadDTO> actividades = _mapper.Map<List<ActividadDTO>>(lista);
                return Ok(actividades);
            }
            catch (GetAllActividadesLAException e) { throw new ActividadesControllerException(e.Message); }
            catch (ActividadesControllerException e) { throw new ActividadesControllerException(e.Message); }
            catch (Exception) { throw new ActividadesControllerException("Ha ocurrido un error inesperado!"); }
        }

        // POST api/<ActividadesController>
        [HttpPost]
        public ActionResult<Actividad> Post(ActividadDTO objDto)
        {
            try
            {
                if (objDto == null) throw new ActividadesControllerException("No se ha recibido una actividad para dar de alta!");
                var actividad=_mapper.Map<Actividad>(objDto);
                _new.NewObj(actividad);
                return Created($"Se ha dado de alta la actividad {objDto.Nombre}", objDto);
            }
            catch (NewActividadLAException e) { throw new ActividadesControllerException(e.Message); }
            catch (ActividadesControllerException e) { throw new ActividadesControllerException(e.Message); }
            catch (Exception) { throw new ActividadesControllerException("Ha ocurrido un error inesperado!"); }

        }

        // PUT api/<ActividadesController>/5
        [HttpPut("{id}")]
        public ActionResult<Actividad> Put(ActividadDTO objDto)
        {
            try
            {
                if (objDto == null) throw new ActividadesControllerException("No se ha recibido una actividad para dar de alta!");
                var actividad=_mapper.Map<Actividad>(objDto);
                _update.UpdateObj(actividad);
                return Ok($"Se ha modificado la actividad ${objDto.Nombre} correctamente!");
            }
            catch (UpdateActividadLAException e) { throw new ActividadesControllerException(e.Message); }
            catch (ActividadesControllerException e) { throw new ActividadesControllerException(e.Message); }
            catch (Exception) { throw new ActividadesControllerException("Ha ocurrido un error inesperado!"); }

        }

        // DELETE api/<ActividadesController>/5
        [HttpDelete("{id}")]
        public ActionResult<Actividad> Delete(int id)
        {
            try
            {
                var actividad = _get.GetObject(id);
                if (actividad.Id != id) throw new ActividadesControllerException("Las actividades no coinciden, error inesperado! ");
                _delete.DeleteObj(actividad);
                return Ok($"Se ha eliminado la actividad {actividad.Nombre.Data} correctamente!");
            }
            catch (DeleteActividadLAException e) { throw new ActividadesControllerException(e.Message); }
            catch (ActividadesControllerException e) { throw new ActividadesControllerException(e.Message); }
            catch (Exception) { throw new ActividadesControllerException("Ha ocurrido un error inesperado!"); }
        }
    }
}
