using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodManager.Model
{
    public class Recipe
    {
        [Required]
        public string Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public IEnumerable<Step> Steps { get; set; }
    }
}