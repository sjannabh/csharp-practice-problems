namespace csharp_practice_problems.Problems
{
    public class ReplaceDigit
    {
        public int replace(int num) //105
        {
            int result = 0;
            int digit = 5;
            int ans = 0;
            if (num == 0)
            {
                return digit;
            }

            else
            {
                while(num > 0)
                {
                    if(num % 10 == 0)
                    {
                        result = result * 10 + digit;
                    }
                    else
                    {
                        result = result * 10 + num % 10;
                    }
                    num /= 10;
                }
            }
            while(result > 0)
            {
                ans = ans * 10 + result % 10;
                result = result / 10;

            }

            return ans;
        }
    }
}
