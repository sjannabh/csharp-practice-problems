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

            //Reverse each word in a string
            ReverseEachWord reverseEachWord = new ReverseEachWord();
            Console.WriteLine("-------------- Reversing each word in a string --------------------");
            reverseEachWord.WordReverse("Hello World");

            //Count the occurence of the letter in string
            CharacterOccurence characterOccurence = new CharacterOccurence();
            Console.WriteLine("-------------- Count the occurence of each character --------------------");
            characterOccurence.CountOccurrence("Hello World");

            //Remove duplicate characters
            RemoveDuplicates removeDuplicates = new RemoveDuplicates();
            Console.WriteLine("-------------- Remove duplicate characters --------------------");
            removeDuplicates.remDuplicates("csharpcorner");

            //all possible substrings of the string
            PossibleSubstrings possibleSubstrings = new PossibleSubstrings();
            Console.WriteLine("--------------- Possible substrings of a string -----------------");
            possibleSubstrings.PosSubString("abcd");

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
