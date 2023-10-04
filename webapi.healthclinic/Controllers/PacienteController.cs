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
    public class PacienteController : ControllerBase
    {
        private IPacienteRepository _pacienteRepository;
        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();
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
                _pacienteRepository.BuscarConsultas(consulta, id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de cadastrar um paciente
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Paciente paciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(paciente);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de deletar um paciente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _pacienteRepository.Deletar(id);
                return StatusCode(203);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        ///  endpoint que aciona o método de listar os pacientes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_pacienteRepository.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
