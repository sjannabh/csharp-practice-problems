namespace csharp_practice_problems.Problems
{
    public class Palindrome
    {
        public string PalindromeOrNot(string text)
        {
            bool flag = false;
            for (int i = 0, j = text.Length - 1; i < j; i++)
            {
                if (text[i] == text[j])
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag)
            {
                return ("" + text + " is a palindrome");
            }
            else
            {
                return ("" + text + " is not a palindrome");
            }

        }

    }
}
