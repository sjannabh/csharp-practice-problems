namespace csharp_practice_problems.Problems
{
    public class SumOfSumSeries
    {
        public void SumSumSeries(int n)
        {
            int[] sumSeries = new int[n];
            sumSeries[0] = 1;
            for(int i = 1; i < n; i++)
            {
                sumSeries[i] = sumSeries[i - 1] + (i + 1);
            }
            Console.Write("The sum series of " +n+ " Natural number is: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(sumSeries[i] + " ");
            }
            Console.WriteLine();
            int[] sumSumSeries = new int[n];

            sumSumSeries[0] = sumSeries[0];
            for(int i = 1;i < n; i++)
            {
                sumSumSeries[i] = (sumSumSeries[i - 1]) + sumSeries[i];
            }

            Console.WriteLine("Sum of sum-series of first "+n+ " Natural Number is: " + sumSumSeries[n - 1]);
        }

        public void approach2(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum = sum + (i * (i + 1) / 2);  // sum + n(n+1)/2
            }
            Console.WriteLine(sum);
        }
    }
}
