using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly ClinicContext _clinicContext;

        public void Cadastrar(Clinica clinica)
        {
            _clinicContext.Clinica.Add(clinica);
            _clinicContext.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            return _clinicContext.Clinica.ToList();
        }
    }
}
