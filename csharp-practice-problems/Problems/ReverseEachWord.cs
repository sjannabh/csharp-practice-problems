using System.Text;

namespace csharp_practice_problems.Problems
{
    public class ReverseEachWord
    {
        public void WordReverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            int i;
            int Start = str.Length - 1;
            int End = str.Length-1;

            while(Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        sb.Append(str[End]);
                        End--;
                    }
                    sb.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }
            for (i =End; i>=0; i--)
            {
                sb.Append(str[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
