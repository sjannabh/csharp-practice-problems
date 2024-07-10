
namespace csharp_practice_problems.Problems
{
    public class SumOfDigitsIsPalindrome
    {
        public void digitSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            bool flag = isPalindrome(sum);
            if (flag)
            {
                Console.WriteLine("The sum of digits is a palindrome");
            }
            else
            {
                Console.WriteLine("The sum of digits is not a palindrome");
            }

        }

        public bool isPalindrome(int n)
        {
            string num = n.ToString();
            bool result = false;

            for(int i=0,j=num.Length-1; i < j; i++, j--)
            {
                if (num[i] == num[j])
                {
                    result = true;
                    continue;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
