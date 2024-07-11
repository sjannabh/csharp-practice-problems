namespace csharp_practice_problems.Problems
{
    public class ArithmeticSeries // a, a+d, a+2d, a+3d ........
    {
        public void SumOfAS(float a, float d, int n)
        {
            float sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += a + i * d;
            }
            Console.WriteLine("Sum of arithmetic series is: " + sum);
        }
    }
}
