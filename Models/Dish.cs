using System;
using System.ComponentModel.DataAnnotations;

namespace Chefs__N_Dishes.Models
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public virtual Chef Chef { get; set; }
        [Range(1,5, ErrorMessage="Tastiness must be between 1 and 5")]
        [Required]
        public int Tastiness { get; set; }
        [Range(0, Double.PositiveInfinity)]
        [Required]
        public string Calories { get; set; }
        [Required]
        public string Description { get; set; }
    }
}