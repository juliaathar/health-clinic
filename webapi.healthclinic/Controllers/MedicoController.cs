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
    public class MedicoController : ControllerBase
    {
        private IMedicoRepository _medicoRepository;

        public MedicoController()
        {
            _medicoRepository = new MedicoRepository();
        }

        /// <summary>
        ///  endpoint que aciona o método de buscar consultas
        /// </summary>
        /// <param name="consulta"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetAppointments(Consulta consulta, Guid id)
        {
            try
            {
                _medicoRepository.BuscarConsultas(consulta, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de cadastrar um medico
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Post(Medico medico)
        {
            try
            {
                _medicoRepository.Cadastrar(medico);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de deletar um medico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _medicoRepository.Deletar(id);
                return StatusCode(203);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        /// <summary>
        ///  endpoint que aciona o método de listar os medicos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_medicoRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
