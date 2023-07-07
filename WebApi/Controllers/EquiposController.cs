using AutoMapper;
using LogicaAplicacion.CasosUso.Equipos;
using LogicaAplicacion.Exceptions.Equipos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApi.DTOs;
using WebApi.Excepciones;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private IMapper _mapper;
        private DeleteEquipo _delete;
        private GetAllEquipo _getAll;
        private GetEquipo _get;
        private NewEquipo _new;
        private UpdateEquipo _update;

        public EquiposController(IMapper mapper, DeleteEquipo delete, GetAllEquipo getAll,
                                 GetEquipo get, NewEquipo @new, UpdateEquipo update)
        {
            _mapper = mapper;
            _delete = delete;
            _getAll = getAll;
            _get = get;
            _new = @new;
            _update = update;
        }


        // GET: api/<EquiposController>
        [HttpGet]
        public ActionResult Get(int id)
        {
            try
            {
                var equipo = _get.GetObject(id);
                if (equipo == null) { throw new EquiposControllerException("No se ha encontrado el equipo buscado!"); }
                return Ok(equipo);
            }
            catch (GetEquipoLAException e) { throw new EquiposControllerException(e.Message); }
            catch (EquiposControllerException e) { throw new EquiposControllerException(e.Message); }
            catch (Exception) { throw new EquiposControllerException("Ha ocurrido un error inesperado!"); }
        }

        // GET api/<EquiposController>/5
        [HttpGet("{id}")]
        public ActionResult GetAll()
        {
            try
            {
                List<EquipoDTO> list = _mapper.Map<List<EquipoDTO>>(_getAll.GetAllObj());
                if(list.IsNullOrEmpty()) { throw new EquiposControllerException("No se han encontrado equipos en la base de datos!"); }
                return Ok(list);
            }
            catch (GetAllEquipoLAException e) { throw new EquiposControllerException(e.Message); }
            catch (EquiposControllerException e) { throw new EquiposControllerException(e.Message); }
            catch (Exception) { throw new EquiposControllerException("Ha ocurrido un error inesperado!"); }
        }

        // POST api/<EquiposController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EquiposController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EquiposController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
