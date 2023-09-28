using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IClinicaRepository
    {
        List<Clinica> Listar();
        void Cadastrar(Clinica clinica);
        void Atualizar(Clinica clinica, Guid id);
    }
}
