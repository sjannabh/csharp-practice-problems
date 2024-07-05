using csharp_practice_problems.Models;
using csharp_practice_problems.Problems;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharp_practice_problems.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Reversing a string
            ReverseAString reverseAString = new ReverseAString();
            Console.WriteLine(reverseAString.StringReverse("Hello World"));



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
