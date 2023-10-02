using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly ClinicContext _clinicContext;
        public void Atualizar(Consulta consulta, Guid id)
        {
            Consulta consultaBuscada = _clinicContext.Consulta.Find(id)!;

            if (consultaBuscada != null)
            {
                consultaBuscada.DataConsulta = consultaBuscada.DataConsulta!;
            }

            _clinicContext.Consulta.Update(consultaBuscada!);

            _clinicContext.SaveChanges();
        }

        public void Cadastrar(Consulta consulta)
        {
            _clinicContext.Consulta.Add(consulta);
            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Consulta consultaBuscada = _clinicContext.Consulta.Select(u => new Consulta
                {
                    IdConsulta = u.IdConsulta
                }).FirstOrDefault(u=> u.IdConsulta == id)!; 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Consulta> Listar()
        {
            return _clinicContext.Consulta.ToList();
        }
    }
}
