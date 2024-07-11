namespace csharp_practice_problems.Problems
{
    public class NthTermOfSeries
    {
        public void findN(int n)
        {
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("The Nth term is: " + sum);
        }
        public int approach2(int n)
        {
            return (n * (n + 1)) / 2;
        }
    }
}
