namespace csharp_practice_problems.Problems
{
    public class SumOfDiagonals
    {
        public void diagnolsSum(int[,] arr, out int res1, out int res2)
        {
            // there are two diagonals in a 2D square matrix
            // Principle diagonal - a00, a11, a22, a33
            // Secondary diagonal - a03, a12, a21, a30

            int diagSum1 = 0;
            int diagSum2 = 0;

            for(int i=0;i<arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        diagSum1 += arr[i, j];
                    }

                    if(i+j == arr.GetLength(0) - 1)
                    {
                        diagSum2 += arr[i, j];
                    }
                }
            }
            res1 = diagSum1;
            res2 = diagSum2;

            Console.WriteLine("Principle Diagonal Sum = " + diagSum1);
            Console.WriteLine("Secondary Diagonal Sum = " + diagSum2);
        }
    }
}
