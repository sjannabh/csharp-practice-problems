using System.Collections.Immutable;
using System.Text;

namespace csharp_practice_problems.Problems
{
    public class UncommonCharacters
    {
        public void printUncommonChar(string str1, string str2)
        {
            Dictionary<char, int> kValStr1 = new Dictionary<char, int>();
            Dictionary<char, int> kValStr2 = new Dictionary<char, int>();
            string sb = "";

            foreach (char c in str1)
            {
                if (!kValStr1.ContainsKey(c))
                {
                    kValStr1[c] = 1;
                }
            }
            foreach (char c in str2)
            {
                if (!kValStr2.ContainsKey(c))
                {
                    kValStr2[c] = 1;
                }
            }

            foreach (var item in kValStr1)
            {
                if (!kValStr2.ContainsKey(item.Key))
                {
                    sb += item.Key;
                    sb += " ";
                }
            }

            foreach (var item in kValStr2)
            {
                if (!kValStr1.ContainsKey(item.Key))
                {
                    sb += item.Key;
                    sb += " ";
                }
            }


            char[] chars = sb.ToCharArray();

            Array.Sort(chars);

            sb = new string(chars);

            if (sb.Length == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {

                Console.WriteLine(sb + " ");

            }

        }
    }
}
