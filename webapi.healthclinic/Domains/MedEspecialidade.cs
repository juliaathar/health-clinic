using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(MedEspecialidade))]
    public class MedEspecialidade
    {
        [Key]
        public Guid IdMedEspecialidade { get; set; } = Guid.NewGuid();
    }
}
