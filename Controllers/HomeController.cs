using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chefs__N_Dishes.Models;
using Chefs__N_Dishes.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Chefs__N_Dishes.Controllers
{
    public class HomeController : Controller
    {
        private ChefsNDishesDbContext _dbcontext;
        public HomeController(ChefsNDishesDbContext context) {
            _dbcontext = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Chef> chefs = _dbcontext.Chefs.Include(c => c.Dishes);
            
            return View(chefs);
        }

        [Route("/dishes")]
        public IActionResult Dishes(){

            IEnumerable<Dish> dishes = _dbcontext.Dishes.Include(d => d.Chef);

            return View(dishes);
        }

        [HttpGet]
        [Route("/new")]
        public IActionResult AddChef(){
            return View();
        }

        [HttpPost]
        [Route("/new")]
        public IActionResult AddChef(Chef elem) {
            if(!ModelState.IsValid)
                return View(elem);
            
            _dbcontext.Add(elem);
            _dbcontext.SaveChanges();

            return Redirect("/");
        }

        [HttpGet]
        [Route("/dishes/new")]
        public IActionResult AddDish(){

            DishesViewModel vm = new DishesViewModel();
            vm.Chefs = _dbcontext.Chefs;
            
            return View(vm);
        }

        [HttpPost]
        [Route("/dishes/new")]
        public IActionResult AddDish(DishesViewModel elem){
            if(!ModelState.IsValid) {
                DishesViewModel vm = elem;

                return View(vm);
            }

            // elem.Dish.Chef = _dbcontext.Chefs.Where(c => c.Id == elem.Dish.ChefId).FirstOrDefault();
            _dbcontext.Add(elem.Dish);
            _dbcontext.SaveChanges();

            return Redirect("/dishes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
