using Chefs__N_Dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace Chefs__N_Dishes.Persistance
{
    public class ChefsNDishesDbContext: DbContext
    {
        public DbSet<Dish> Dishes { get; set; } 
        public DbSet<Chef> Chefs { get; set; } 

        public ChefsNDishesDbContext(DbContextOptions<ChefsNDishesDbContext> options)
            : base(options)
        {
            
        }
    }
}