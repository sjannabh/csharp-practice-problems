using System.Text;

namespace csharp_practice_problems.Problems
{
    public class CharListToString
    {
        public void charactToString(char[] chars)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in chars) 
            {
                sb.Append(c);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
