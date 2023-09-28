using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class TipoDeUsuarioRepository : ITipoDeUsuarioRepository
    {
        private readonly ClinicContext _clinicContext;
        public TipoDeUsuarioRepository()
        {
            _clinicContext = new ClinicContext();
        }
        public List<TipoDeUsuario> Listar()
        {
            return _clinicContext.TipoDeUsuario.ToList();
        }
    }
}
