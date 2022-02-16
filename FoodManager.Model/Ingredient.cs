using System.ComponentModel.DataAnnotations;

namespace FoodManager.Model
{
    public class Ingredient
    {
        [Required]
        public string Name { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        public UnitOfMeasurement QuantityUom { get; set; }
    }
}