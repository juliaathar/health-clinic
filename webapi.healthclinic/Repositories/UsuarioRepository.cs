using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ClinicContext _clinicContext;
        public void Atualizar(Usuario usuario, Guid id)
        {
            Usuario usuarioBuscado = _clinicContext.Usuario.Find(id)!;

            if (usuarioBuscado != null)
            {
                usuarioBuscado.Email = usuarioBuscado.Email!;
            }

            _clinicContext.Usuario.Update(usuarioBuscado!);

            _clinicContext.SaveChanges();
        }

        public Usuario Buscar(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _clinicContext.Usuario.Select(u => new Usuario
                {
                    IdUsuario = u.IdUsuario,
                    Nome = u.Nome,
                    Email = u.Email

                }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            _clinicContext.Usuario.Add(usuario);

            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _clinicContext.Usuario.Find(id)!;

                _clinicContext.Usuario.Remove(usuarioBuscado);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Usuario> Listar()
        {
            return _clinicContext.Usuario.ToList();
        }
    }
}
