using System.Text;

namespace csharp_practice_problems.Problems
{
    public class ReverseNumber
    {
        public void reverse(int n)
        {
            StringBuilder sb = new StringBuilder(); 

            while (n > 0)
            {
                sb.Append(n % 10);
                n = n / 10;
            }

            Console.WriteLine(sb.ToString());
        }

        public void apprach2(int n)
        {
            int res = 0;
            while (n > 0)
            {
                res = res * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine(res);
        }
    }
}
