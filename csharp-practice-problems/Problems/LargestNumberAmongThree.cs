namespace csharp_practice_problems.Problems
{
    public class LargestNumberAmongThree
    {
        public void largestNum(int a, int b, int c)
        {
            if(a>b && a > c)
            {
                Console.WriteLine(a + " is greater than " + b + " and " + c);
            }
            else if(a<b && b > c)
            {
                Console.WriteLine(b + " is greater than " + a + " and " + c);

            }
            else
            {
                Console.WriteLine(c + " is greater than " + a + " and " + b);

            }
        }
    }
}
