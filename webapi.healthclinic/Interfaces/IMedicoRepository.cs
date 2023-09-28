using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IMedicoRepository
    {
        List<Consulta> Listar();
    }
}
