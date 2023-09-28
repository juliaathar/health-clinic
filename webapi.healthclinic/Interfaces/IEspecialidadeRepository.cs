using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        List<Especialidade> Listar();

        void Atualizar(Especialidade especialidade, Guid id);

        void Deletar(Guid id);
    }
}
