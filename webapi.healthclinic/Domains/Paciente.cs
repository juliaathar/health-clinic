using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Paciente))]
    [Index(nameof(RG), IsUnique = true)]
    [Index(nameof(CPF), IsUnique = true)]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(9)]
        [Required(ErrorMessage = "Informe o RG")]
        public string? RG { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe o CPF")]
        public string? CPF { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Informe a data de nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe o telefone")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Informe qual seu usuário")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

    }
}
