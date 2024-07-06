namespace csharp_practice_problems.Problems
{
    public class SumOfDigits
    {
        public void DigitsSum(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
