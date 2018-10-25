using System.Collections.Generic;
using Chefs__N_Dishes.Persistance;

namespace Chefs__N_Dishes.Models
{
    public class DishesViewModel
    {
        
        public Dish Dish { get; set; } = new Dish();
        public IEnumerable<Chef> Chefs { 
            get; set;
        }
    }
}