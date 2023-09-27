using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.healthclinic.Domains
{
    [Table(nameof(TipoDeUsuario))]
    public class TipoDeUsuario
    {
        [Key] 
        public Guid IdTipoDeUsuario { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Título de usuário obrigatório")]
        public string? Titulo { get; set; }
    }
}
