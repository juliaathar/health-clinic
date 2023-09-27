using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(MedEspecialidade))]
    public class MedEspecialidade
    {
        [Key]
        public Guid IdMedEspecialidade { get; set; }

        [Required(ErrorMessage = "Informe o médico")]
        public Guid IdMedico { get; set; } 

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }

        [Required(ErrorMessage = "Informe a especialidade")]
        public Guid IdEspecialidade { get; set; }

        [ForeignKey(nameof(IdEspecialidade))]

        public Especialidade? Especialidade { get; set; }
    }
}
