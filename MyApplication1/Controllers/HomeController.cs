using Microsoft.AspNetCore.Mvc;
using MyApplication1.Models;
using System.Diagnostics;

namespace MyApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<NameModel> namesList = new List<NameModel>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //NameModel new_name = new NameModel() { Name = "Majid", Description = "This is my name" };

            return View(namesList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Resume()
        {
            var new_name = new NameModel();

            return View(new_name);
        }

        public IActionResult newName(NameModel nameModel)
        {
            namesList.Add(nameModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}