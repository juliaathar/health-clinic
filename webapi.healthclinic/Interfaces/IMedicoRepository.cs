using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        void Deletar(Guid id);

        List<Medico> Listar();

        void BuscarConsultas(Consulta consulta, Guid id);
    }
}
