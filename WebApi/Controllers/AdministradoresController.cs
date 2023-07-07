using AutoMapper;
using LogicaAplicacion.CasosUso.Administradores;
using LogicaAplicacion.Exceptions.Administradores;
using LogicaNegocio.Entidades;
using LogicaNegocio.Entidades.Actividades;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;
using WebApi.Excepciones;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradoresController : ControllerBase
    {
        private IMapper _mapper;
        private DeleteAdministrador _delete;
        private GetAdministrador _get;
        private GetAllAdministrador _getAll;
        private NewAdministrador _new;
        private UpdateAdministrador _update;

        public AdministradoresController(IMapper mapper, DeleteAdministrador delete, GetAdministrador get,
                                         GetAllAdministrador getAll, NewAdministrador @new, UpdateAdministrador update)
        {
            _mapper = mapper;
            _delete = delete;
            _get = get;
            _getAll = getAll;
            _new = @new;
            _update = update;
        }


        // GET: api/<AdministradoresController>
        [HttpGet]
        public ActionResult Get(int id)
        {
            try
            {
                AdministradorDTO administradorDto = _mapper.Map<AdministradorDTO>(_get.GetObject(id));
                if (administradorDto == null) { throw new AdministradoresControllerException("No se ha encontrado al administrador!"); }
                return Ok(administradorDto);
            }
            catch (GetAdministradorLAException e) {throw new AdministradoresControllerException(e.Message); }
            catch (AdministradoresControllerException e) { throw new AdministradoresControllerException(e.Message); }
            catch (Exception) { throw new AdministradoresControllerException("Ha ocurrido un error inesperado!"); }
        }

        // GET api/<AdministradoresController>/5
        [HttpGet("{id}")]
        public ActionResult GetAll(int id)
        {
            try
            {
                List<AdministradorDTO> list = _mapper.Map<List<AdministradorDTO>>(_getAll.GetAllObj());
                if (list == null) { throw new AdministradoresControllerException("No se han encontrado administradores en la base de datos!"); }
                return Ok(list);
            }
            catch (GetAllAdministradoresLAException e) { throw new AdministradoresControllerException(e.Message); }
            catch (AdministradoresControllerException e) { throw new AdministradoresControllerException(e.Message); }
            catch (Exception) { throw new AdministradoresControllerException("Ha ocurrido un error inesperado!"); }
        }

        // POST api/<AdministradoresController>
        [HttpPost]
        public ActionResult<Administrador> Post(AdministradorDTO objDto)
        {
            try
            {
                if(objDto == null) { throw new AdministradoresControllerException("No se ha recibido un administrador para dar de alta!"); }
                var administrador=_mapper.Map<Administrador>(objDto);
                _new.NewObj(administrador);
                return Created($"Se ha creado al administrador {objDto.Name}",administrador);
            }
            catch (NewAdministradorLAException e) { throw new AdministradoresControllerException(e.Message); }
            catch (AdministradoresControllerException e) { throw new AdministradoresControllerException(e.Message); }
            catch (Exception) { throw new AdministradoresControllerException("Ha ocurrido un error inesperado!"); }
        }

        // PUT api/<AdministradoresController>/5
        [HttpPut("{id}")]
        public ActionResult<Administrador> Put(AdministradorDTO objDto)
        {
            try
            {
                if (objDto==null) { throw new AdministradoresControllerException("No se ha recibido un administrador para actualizar!"); }
                var administrador = _mapper.Map<Administrador>(objDto);
                _update.UpdateObj(administrador);
                return Ok($"Se actualizo correcatemente el administrador!");
            }
            catch (UpdateAdministradorLAException e) { throw new AdministradoresControllerException(e.Message); }
            catch (AdministradoresControllerException e) { throw new AdministradoresControllerException(e.Message); }
            catch (Exception) { throw new AdministradoresControllerException("Ha ocurrido un error inesperado!"); }
        }

        // DELETE api/<AdministradoresController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var administrador = _get.GetObject(id);
                if (administrador==null) { throw new AdministradoresControllerException("No se ha podido eliminar al administrador!"); }
                _delete.DeleteObj(administrador);
                return Ok($"Se ha eliminado correctamente al administrador {administrador.Email.Data}");
            }
            catch (DeleteAdministradorLAException e) { throw new AdministradoresControllerException(e.Message); }
            catch (AdministradoresControllerException e) { throw new AdministradoresControllerException(e.Message); }
            catch (Exception) { throw new AdministradoresControllerException("Ha ocurrido un error inesperado!"); }
        }
    }
}
