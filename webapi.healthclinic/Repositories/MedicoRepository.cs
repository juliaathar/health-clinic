using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Repositories
{
    public class MedicoRepository
    {
        private readonly ClinicContext _clinicContext;
        public void BuscarConsultas(Consulta consulta, Guid id)
        {
            try
            {
                Consulta medicoConsulta = _clinicContext.Consulta.Select(u => new Consulta
                {
                    Paciente = u.Paciente,
                    DataConsulta = u.DataConsulta,
                    HorarioConsulta = u.HorarioConsulta
                }).FirstOrDefault(u => u.IdConsulta == id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Medico medico)
        {
            _clinicContext.Medico.Add(medico);

            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Medico medicoBuscado = _clinicContext.Medico.Find(id)!;

                _clinicContext.Medico.Remove(medicoBuscado);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medico> Listar()
        {
            return _clinicContext.Medico.ToList();
        }
    }
}
