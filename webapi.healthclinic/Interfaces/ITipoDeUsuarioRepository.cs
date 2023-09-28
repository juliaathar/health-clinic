using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Interfaces
{
    public interface ITipoDeUsuarioRepository
    {
        List<TipoDeUsuario> Listar();
    }
}
