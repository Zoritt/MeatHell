using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MH.Models
{
    public class Meal : AuditEntity
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(200)")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        [Column(TypeName ="varchar(500)")]
        public string Description { get; set; }
    }
}
