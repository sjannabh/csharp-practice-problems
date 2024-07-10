namespace csharp_practice_problems.Problems
{
    public class MultiplicationTable
    {
        public void table(int n)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
        }
    }
}
