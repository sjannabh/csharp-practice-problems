using System.Text;

namespace csharp_practice_problems.Problems
{
    public class PossibleSubstrings
    {
        public void PosSubString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < str.Length; i++)
            {
                string result = "";
                for (int j = i; j < str.Length; j++) 
                {
                    result+= str[j];
                    sb.Append(result + ' ');
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
