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
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository;

        public ClinicaController()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        /// <summary>
        ///  endpoint que aciona o método de cadastrar uma clinica
        /// </summary>
        /// <param name="clinica"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Clinica clinica)
        {
            try
            {
                _clinicaRepository.Cadastrar(clinica);

                return Ok(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
