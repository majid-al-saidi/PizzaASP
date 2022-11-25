using Microsoft.AspNetCore.Mvc;

namespace MyApplication1.Controllers
{
    public class OutsideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
