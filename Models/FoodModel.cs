using System.ComponentModel.DataAnnotations;

namespace Backend_WEBAPP.Models
{
    public class FoodModel
    {
        //public object? _id { get; set; }

        [Required]
        public required string Name { get; set; }

        public uint Quantity { get; set; } = 0;

        public uint Price { get; set; } = 0;
    }
}