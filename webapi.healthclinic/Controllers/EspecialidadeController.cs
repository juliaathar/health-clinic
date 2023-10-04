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
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }


        /// <summary>
        ///  endpoint que aciona o método de cadastrar uma especialidade
        /// </summary>
        /// <param name="especialidade"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Especialidade especialidade)
        {
            try
            {
                _especialidadeRepository.Cadastrar(especialidade);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de listar as especialidades
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_especialidadeRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de deletar uma especialidade
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _especialidadeRepository.Deletar(id);
                return StatusCode(203);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
