using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI23.DAL.Entities
{
    public class AuditBase
    {
        [Key] // pk
        [Required]// obligatorio
        public virtual Guid Id{ get; set; } // PK de las tablas
        public virtual DateTime? CreatedDate{ get; set; } //  guardar registro nuevo con fecha
        public virtual DateTime? ModifiedDate { get; set; } // guardar registro modificado

    }
}
