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
    public class ComentarioController : ControllerBase
    {
        private IComentarioRepository _comentarioRepository;

        public ComentarioController()
        {
            _comentarioRepository = new ComentarioRepository();
        }

        /// <summary>
        ///  endpoint que aciona o método de cadastrar um comentario
        /// </summary>
        /// <param name="comentario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Comentario comentario)
        {
            try
            {
                _comentarioRepository.Comentar(comentario);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// endpoint que aciona o método de listar os comentários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_comentarioRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// endpoint que aciona o método de deletar comentário
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Comentario comentario, Guid id)
        {
            try
            {
                _comentarioRepository.Deletar(comentario, id);
                return StatusCode(203);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
