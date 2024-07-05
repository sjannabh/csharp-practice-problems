namespace csharp_practice_problems.Problems
{
    public class ReverseAString
    {
        public string StringReverse(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }

            string output = new string(chars);

            return output;
        }
    }


}
