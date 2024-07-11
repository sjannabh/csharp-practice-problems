using System.Security.Cryptography.X509Certificates;

namespace csharp_practice_problems.Problems
{
    public class GeometricSeries// a, ar , ar2, ar3,.......
    {
        public void SumOfGS(double a, double r, int n)
        {
            double result = 0;

            for(int i=0; i<n; i++)
            {
                result += a * Math.Pow(r, i);
            }

            Console.WriteLine(result);
        }
    }
}
