using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Deletar(Guid id);

        List<Paciente> Listar();

        void BuscarConsultas(Consulta consulta, Guid id);
    }
}
