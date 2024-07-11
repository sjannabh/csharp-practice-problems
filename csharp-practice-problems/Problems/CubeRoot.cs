namespace csharp_practice_problems.Problems
{
    public class CubeRoot
    {
        public void FindCubeRoot(int n)
        {
            double result = Math.Cbrt(n);
            Console.WriteLine("Cube root of the number " + n + " is: " + result);
        }
    }
}
