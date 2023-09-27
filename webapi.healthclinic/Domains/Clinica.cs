using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webapi.healthclinic.Utils;

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

        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Informe o horário de abertura")]
        public TimeSpanConvert? HorarioAbertura { get; set; }


        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Informe o horário de abertura")]
        public TimeSpanConvert? HorarioFechamento { get; set; }
    }
}
