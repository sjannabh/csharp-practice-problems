namespace csharp_practice_problems.Problems
{
    public class FloydTriangle
    {
        public void FTraingle(int n)
        {
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    sum += 1;
                    Console.Write(sum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
