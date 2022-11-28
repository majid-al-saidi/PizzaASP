using chapter2.data;
using chapter2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace chapter2.Pages.Admin
{
    public class OrdersModel : PageModel
    {
        
        public List<PizzaOrders> pizzaOrders = new List<PizzaOrders>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            pizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
