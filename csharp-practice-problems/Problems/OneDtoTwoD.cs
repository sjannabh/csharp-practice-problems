namespace csharp_practice_problems.Problems
{
    public class OneDtoTwoD
    {
        public void convertOneD(int[] arr, int row, int col)
        {
            int[,] result = new int[row, col];
            int k = 0;
            for(int i = 0; i < row; i++)
            {
                Console.Write("{");
                for(int j = 0; j < col; j++)
                {
                    result[i, j] = arr[k];
                    k++;
                    Console.Write(result[i, j] + " ");
                }
                Console.Write("}");
                Console.WriteLine(); 
            }

           

        }
    }
}
