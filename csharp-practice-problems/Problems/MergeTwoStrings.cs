using System.Text;

namespace csharp_practice_problems.Problems
{
    public class MergeTwoStrings
    {
        public void merge(string str1, string str2)
        {
           StringBuilder sb = new StringBuilder();
            int i = 0, j = 0;
            while(i<str1.Length && j < str2.Length)
            {
                sb.Append(str1[i]);
                sb.Append(str2[j]);
                i++;
                j++;
            }
            while (i < str1.Length)
            {
                sb.Append(str1[i]);
                i++;
            }
            while (j < str2.Length)
            {
                sb.Append(str2[j]);
                j++;
            }
            Console.WriteLine("Resultant merged string of given two strings is: " + sb.ToString());
        }
    }
}
