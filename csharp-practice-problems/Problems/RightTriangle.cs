namespace csharp_practice_problems.Problems
{
    public class RightTriangle
    {
        public void printRightTriangle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
