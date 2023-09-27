using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Comente sobre a consulta")]
        public string?  Descricao { get; set; }

        [Required(ErrorMessage = "Informe o paciente")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }
    }
}
