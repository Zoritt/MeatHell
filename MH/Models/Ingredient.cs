using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MH.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(200)")]
        public string Name { get; set; }

        public IngredientType IngredientType { get; set; }
        public int IngredientTypeId { get; set; }

    }
}
