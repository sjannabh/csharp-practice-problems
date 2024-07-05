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
            Console.WriteLine("--------- Reverse a string ----------------");
            Console.WriteLine(reverseAString.StringReverse("Hello World"));

            //Palindrome or not
            Palindrome palindrome = new Palindrome();
            Console.WriteLine("------------- Palindrome -------------");
            Console.WriteLine(palindrome.PalindromeOrNot("madam"));
            Console.WriteLine(palindrome.PalindromeOrNot("Honey"));

            //Revese the words in a string
            ReverseOrderOfWords reverseOrderOfWords = new ReverseOrderOfWords();
            Console.WriteLine("----------- Reversing words in string --------------");
            reverseOrderOfWords.reverseWords("Hello World");


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
