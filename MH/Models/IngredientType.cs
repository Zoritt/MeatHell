using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MH.Models
{
    public class IngredientType
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string Name { get; set; }
    }
}
