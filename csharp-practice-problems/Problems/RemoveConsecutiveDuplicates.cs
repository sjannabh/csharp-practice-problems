using System.Text;

namespace csharp_practice_problems.Problems
{
    public class RemoveConsecutiveDuplicates
    {
        public void remConDupl(string str) //aabbcc
        {
            StringBuilder sb = new StringBuilder();

            for(int i=1;i< str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    sb.Append(str[i-1]);
                }
            }
            sb.Append(str[str.Length - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}
