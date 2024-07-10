using System.Text;

namespace csharp_practice_problems.Problems
{
    public class ReversingVowelsInString
    {
        public void revStr(string str)
        {
            StringBuilder vowelsStr = new StringBuilder();
            StringBuilder resultStr = new StringBuilder();
            
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'a' || str[i] == 'E' || str[i] == 'e' || str[i] == 'I' || str[i] == 'i' || str[i] =='O' || str[i] == 'o' || str[i] == 'U' || str[i] == 'u')
                {
                    vowelsStr.Append(str[i]);
                }
            }
            string vowel = vowelsStr.ToString();
            int j = vowel.Length-1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'a' || str[i] == 'E' || str[i] == 'e' || str[i] == 'I' || str[i] == 'i' || str[i] == 'O' || str[i] == 'o' || str[i] == 'U' || str[i] == 'u')
                {
                    resultStr.Append(vowelsStr[j]);
                    j--;
                }
                else
                {
                    resultStr.Append(str[i]);
                }
            }
            Console.WriteLine(resultStr.ToString());
        }
    }
}
