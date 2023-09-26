using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName = "INT(9)")]
        [Required(ErrorMessage = "Informe o RG")]

        public string? RG { get; set; }

        [Column(TypeName = "INT(11)")]
        [Required(ErrorMessage = "Informe o CPF")]
        public int? CPF { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Informe a data de nascimento")]
        public DateOnly? DataNascimento { get; set; }

        [Column(TypeName = "INT(11)")]
        [Required(ErrorMessage = "Informe o telefone")]
        public int? Telefone { get; set; }

        [Required(ErrorMessage = "Informe qual seu usuário")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

    }
}
