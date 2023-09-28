using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IComentarioRepository
    {
        void Comentar(Comentario comentario);
        void Deletar(Comentario comentario, Guid id);
        List<Comentario> Listar();
    }
}
