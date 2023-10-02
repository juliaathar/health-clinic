using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);
        List<Consulta> Listar();
        void Atualizar(Consulta consulta, Guid id);
        void Deletar(Guid id);
    }
}
