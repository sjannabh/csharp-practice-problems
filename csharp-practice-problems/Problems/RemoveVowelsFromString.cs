using System.Text;

namespace csharp_practice_problems.Problems
{
    public class RemoveVowelsFromString
    {
        public void removeVowels(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'a' || str[i] == 'E' || str[i] == 'e' || str[i] == 'I' || str[i] == 'i' || str[i] == 'O' || str[i] == 'o' || str[i] == 'U' || str[i] == 'u')
                {
                    continue; 
                }
                else
                {
                    sb.Append(str[i]);
                }
            }
            Console.WriteLine("String without vowels: "+sb.ToString());
        }
    }
}
