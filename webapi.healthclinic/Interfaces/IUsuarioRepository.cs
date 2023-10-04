using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        Usuario Buscar (Guid id);
        List<Usuario> Listar();

        void Atualizar(Usuario usuario, Guid id);

        void Deletar(Guid id);

        Usuario BuscarPorEmailESenha(string email, string senha);

    }
}
