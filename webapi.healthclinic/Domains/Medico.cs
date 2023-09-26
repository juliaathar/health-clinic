using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(Medico))]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; }

        [Column(TypeName = "INT()")]
        public string? RG { get; set; }

        public string? CPF { get; set; }

        public int? Telefone { get; set; }
        public DateOnly DataEspecialidade { get; set; }
        public int? CRM { get; set; }
    }
}
