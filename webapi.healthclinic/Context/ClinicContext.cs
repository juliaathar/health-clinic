using Microsoft.EntityFrameworkCore;
using webapi.healthclinic.Domains;

namespace webapi.healthclinic.Context
{
    public class ClinicContext : DbContext
    {
        public DbSet<TipoDeUsuario> TipoDeUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Medico> Medico { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Especialidade> Especialidade { get; set; }

        public DbSet<MedEspecialidade> MedEspecialidade { get; set; }

        public DbSet<Clinica> Clinica { get; set; }

        public DbSet<Comentario> Comentario { get; set; }

        public DbSet<Consulta> Consulta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE15-S14; Database= HealthClinic_webAPI; User Id= sa; Pwd= Senai@134; TrustServerCertificate= True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
