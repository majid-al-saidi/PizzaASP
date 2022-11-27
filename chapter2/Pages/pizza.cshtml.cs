using chapter2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace chapter2.Pages
{
    public class pizzaModel : PageModel
    {

        public List<PizzasModel> Pizzas_list = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                PizzaName = "Bolognese",
                ImageTitle = "Bolognese",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
             new PizzasModel()
            {
                PizzaName = "Carbonara",
                ImageTitle = "Carbonara",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
              new PizzasModel()
            {
                PizzaName = "Hawaiian",
                ImageTitle = "Hawaiian",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
               new PizzasModel()
            {
                PizzaName = "Margerita",
                ImageTitle = "Margerita",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
                new PizzasModel()
            {
                PizzaName = "MeatFeast",
                ImageTitle = "MeatFeast",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
                 new PizzasModel()
            {
                PizzaName = "Mushroom",
                ImageTitle = "Mushroom",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
                  new PizzasModel()
            {
                PizzaName = "Pepperoni",
                ImageTitle = "Pepperoni",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
                   new PizzasModel()
            {
                PizzaName = "Seafood",
                ImageTitle = "Seafood",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            },
                new PizzasModel()
            {
                PizzaName = "Vegetarian",
                ImageTitle = "Vegetarian",
                TomatoSouce = true,
                Mushroom = true,
                Cheese = true,
                FinalPrice = 10
            }
        };



        public void OnGet()
        {
        }
    }
}
