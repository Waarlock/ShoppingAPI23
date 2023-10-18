using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI23.DAL.Entities
{
    public class Country : AuditBase
    { 
        [Display(Name = "País")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carateres.")]
        public string Name { get; set; }

    }
}
