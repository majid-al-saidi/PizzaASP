using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace chapter2.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }

        public string CustomerName { get; set; }

        public int CustomerPhone { get; set; }

        public int[] OrderValues { get; set; }

        public DateTime current_date { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Create";
            }
            if (string.IsNullOrEmpty(CustomerName))
            {
                CustomerName= "CustomerName";
            }

            
            
        }
    }
}
