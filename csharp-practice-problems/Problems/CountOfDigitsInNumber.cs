namespace csharp_practice_problems.Problems
{
    public class CountOfDigitsInNumber
    {
        public void digitCount(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine("Count of digits in the given integer is: " + count);
        }
    }
}