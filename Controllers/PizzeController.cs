using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzeController : Controller
    {
        public IActionResult Index()
        {
            PizzaContext context = new PizzaContext();
            
            IQueryable<Pizza> pizzas = context.Pizzas;
            return View(pizzas);
            
        }

        public IActionResult Details(int id)
        {
            PizzaContext context = new PizzaContext();
            Pizza pizza = context.Pizzas.Where(pizza => pizza.Id == id).FirstOrDefault();
            return View(pizza);
        }
    }
}
