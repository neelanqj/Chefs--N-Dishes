using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Chefs__N_Dishes.Extensions;

namespace Chefs__N_Dishes.Models
{
    public class Chef
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [CurrentDate(ErrorMessage = "Date must be before or equal to current date")]
        public DateTime DateOfBirth { get;set; }
        public int Age {
            get {                
                DateTime today = DateTime.Today;
                // Calculate the age.
                int age = today.Year - DateOfBirth.Year;

                return age;
            }
        }

        public IEnumerable<Dish> Dishes {get;set;} = new List<Dish>();
    }
}