using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Medico))]
    [Index(nameof(RG), IsUnique = true)]
    [Index(nameof(CPF), IsUnique = true)]
    [Index(nameof(CRM), IsUnique = true)]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(9)]
        [Required(ErrorMessage = "Informe o RG")]
        public string? RG { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe o CPF")]
        public string? CPF { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe o telefone")]
        public string? Telefone { get; set; }


        [Column(TypeName = "CHAR")]
        [StringLength(6)]
        [Required(ErrorMessage = "Informe o CRM")]
        public string? CRM { get; set; }
    }
}
