using System.ComponentModel.DataAnnotations;

namespace FoodManager.Model
{
    public class Step
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Body { get; set; }
    }
}