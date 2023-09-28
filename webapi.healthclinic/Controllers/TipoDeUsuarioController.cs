using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;
using webapi.healthclinic.Repositories;

namespace webapi.healthclinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoDeUsuarioController : ControllerBase
    {
        private ITipoDeUsuarioRepository _tiposDeUsuarioRepository;

        public TipoDeUsuarioController()
        {
            _tiposDeUsuarioRepository = new TipoDeUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<TipoDeUsuario> tipoDeUsuario = _tiposDeUsuarioRepository.Listar();
                return Ok(tipoDeUsuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
