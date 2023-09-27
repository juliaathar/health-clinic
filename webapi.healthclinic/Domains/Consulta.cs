using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using webapi.healthclinic.Utils;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; }

        [Column(TypeName ="DATE")]
        [Required(ErrorMessage = "Informe a data da consulta")]
        public DateTime DataConsulta { get; set; }

        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Informe a hora da consulta")]
        public TimeSpanConvert? HorarioConsulta { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Transcreva o prontuário do paciente")]
        public string? Prontuario { get; set; }

        [Required(ErrorMessage = "Informe o médico")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }

        [Required(ErrorMessage = "Informe as especialidades do médico")]
        public Guid IdMedEspecialidade { get; set; }

        [ForeignKey(nameof(IdMedEspecialidade))]
        public MedEspecialidade? MedEspecialidade { get; set; }

        [Required(ErrorMessage = "Informe o paciente")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }
    }
}
