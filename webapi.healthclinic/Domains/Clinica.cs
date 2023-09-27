using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Informe o nome da clínica")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Informe o endereço da clínica")]
        public string? Endereco { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(14)]
        [Required(ErrorMessage = "Informe o CPNJ")]
        public string? CPNJ { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Informe o horário de abertura")]
        public TimeSpan HorarioAbertura { get; set; }


        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "Informe o horário de abertura")]
        public TimeSpan HorarioFechamento { get; set; }
    }
}
