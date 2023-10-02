using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ClinicContext _clinicContext;

        public void BuscarConsultas(Consulta consulta, Guid id)
        {
            try
            {
                Consulta pacienteConsulta = _clinicContext.Consulta.Select(u => new Consulta
                {
                    MedEspecialidade = u.MedEspecialidade,
                    DataConsulta = u.DataConsulta,
                    HorarioConsulta = u.HorarioConsulta
                }).FirstOrDefault(u => u.IdConsulta == id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Paciente paciente)
        {
            _clinicContext.Paciente.Add(paciente);

            _clinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            try
            {
                Paciente pacienteBuscado = _clinicContext.Paciente.Find(id)!;

                _clinicContext.Paciente.Remove(pacienteBuscado);

                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Paciente> Listar()
        {
            return _clinicContext.Paciente.ToList();    
        }
    }
}
