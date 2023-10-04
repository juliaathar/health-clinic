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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        ///  endpoint que aciona o método de cadastrar um usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de listar usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.Listar());
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de buscar usuario por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                Usuario usuario = _usuarioRepository.Buscar(id);

                return Ok(usuario);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de deletar um usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _usuarioRepository.Deletar(id);
                return StatusCode(203);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de atualizar informacoes de um usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(Usuario usuario, Guid id)
        {
            try
            {
                _usuarioRepository.Atualizar(usuario, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
