using System.ComponentModel.DataAnnotations;

namespace Backend_WEBAPP.Models
{
    public class FoodModel
    {
        //public object? _id { get; set; }

        [Required]
        public required string Name { get; set; }
        
        [Required]
        public required uint Price { get; set; }
    }
}