using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly ClinicContext _clinicContext;

        public void Cadastrar(Especialidade especialidade)
        {
            _clinicContext.Especialidade.Add(especialidade);

            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Especialidade especialidade = _clinicContext.Especialidade.Find(id)!;

                _clinicContext.Especialidade.Remove(especialidade);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Especialidade> Listar()
        {
            return _clinicContext.Especialidade.ToList();
        }
    }
}
