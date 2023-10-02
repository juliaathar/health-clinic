using webapi.healthclinic.Context;
using webapi.healthclinic.Domains;
using webapi.healthclinic.Interfaces;

namespace webapi.healthclinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly ClinicContext _clinicContext;
        public void Comentar(Comentario comentario)
        {
            _clinicContext.Comentario.Add(comentario);

            _clinicContext.SaveChanges();
        }

        public void Deletar(Comentario comentario, Guid id)
        {
            try
            {
                Comentario comentarioBuscado = _clinicContext.Comentario.Find(id)!;

                _clinicContext.Comentario.Remove(comentarioBuscado);
                _clinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Comentario> Listar()
        {
            return _clinicContext.Comentario.ToList();
        }
    }
}
