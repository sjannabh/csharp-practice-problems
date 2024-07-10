
using System.Text;

namespace csharp_practice_problems.Problems
{
    public class RemoveSpaces
    {
        public void spaceRemove(string str)
        {
            Console.WriteLine("Original String: " + str);
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    sb.Append(str[i]);
                }
            }
            Console.WriteLine("Resultant string without any spaces is: " + sb.ToString());
        }
    }
}
