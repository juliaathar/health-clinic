using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface IPacienteRepository
    {
        List<Consulta> ListarConsultas();
        List<Comentario> ListarComentario();
    }
}
