using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;
using webapi.healthclinic.Repositories;
using webapi.healthclinic.ViewModels;

namespace webapi.healthclinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailESenha(usuario.Email, usuario.Senha);

                if (usuarioBuscado == null)
                {
                    return StatusCode(401, "Email ou senha inválidos");
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email!),
                    new Claim(JwtRegisteredClaimNames.Name, usuarioBuscado.Nome!),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.TipoDeUsuario.Titulo!)
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("health-clinic-api-senai-projeto-2-semestre"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "webapi.healthclinic",
                    audience: "webapi.healthclinic",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: creds
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });


            }
            catch (Exception erro)
            {

                return BadRequest();
            }
        }
    }
}
