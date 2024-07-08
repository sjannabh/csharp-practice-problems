using System.Security.Principal;

namespace csharp_practice_problems.Problems
{
    public class SumOfAllMatrixElements
    {
        public void MatrixSum(int[,] arr)
        {
            int total = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    total = total + arr[i, j];
                }
            }
            Console.WriteLine("Sum of all matrix elements is: " + total);
        }
    }
}
