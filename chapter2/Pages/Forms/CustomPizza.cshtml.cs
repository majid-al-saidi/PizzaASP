using chapter2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace chapter2.Pages.Froms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

		[BindProperty]
		public string CustomerName { get; set; }

		[BindProperty]
		public int CustomerPhone { get; set; }

		public float PizzaPrice { get; set; }

        int[] OrderValues = new int[8];


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

           

            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSouce) { PizzaPrice += 1; OrderValues[0] = 1; }
			if (Pizza.Cheese) {PizzaPrice += 1; OrderValues[1] = 1; }
            if (Pizza.Peperoni) {PizzaPrice += 1; OrderValues[2] = 1; }
            if (Pizza.Mushroom) {PizzaPrice += 1; OrderValues[3] = 1; }
            if (Pizza.Tuna) {PizzaPrice += 1; OrderValues[4] = 1; }
            if (Pizza.Pineapple) {PizzaPrice += 1; OrderValues[5] = 1; }
            if (Pizza.Ham) {PizzaPrice += 1; OrderValues[6] = 1; }
            if (Pizza.Beef) {PizzaPrice += 1; OrderValues[7] = 1; }

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName , PizzaPrice , CustomerName , CustomerPhone, OrderValues });
		}
    }
}
