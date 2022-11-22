using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller

 
    {
        public IActionResult Index()
        {
            PizzaDbContext db = new PizzaDbContext();

            List<Pizza> listaPizza = db.Pizzas.ToList();

        return View(listaPizza);
        }

        public IActionResult Dettaglio(int Id)
        {

            PizzaDbContext db = new PizzaDbContext();

            Pizza pizza = db.Pizzas.Where(item => item.Id == Id).FirstOrDefault();

            return View(pizza);
        }
    }
}
