using System.Text;

namespace csharp_practice_problems.Problems
{
    public class RemoveDuplicates
    {
        public void remDuplicates(string str)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                    sb.Append(c);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}


