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
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository _consultaRepository;

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        /// <summary>
        ///  endpoint que aciona o método de cadastrar uma consulta
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Consulta consulta)
        {
            try
            {
                _consultaRepository.Cadastrar(consulta);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de deletar uma consulta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _consultaRepository.Deletar(id);
                return StatusCode(203);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de atualizar uma consulta
        /// </summary>
        /// <param name="consulta"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(Consulta consulta, Guid id)
        {
            try
            {
                _consultaRepository.Atualizar(consulta, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
