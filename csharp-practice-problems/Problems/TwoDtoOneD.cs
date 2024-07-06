namespace csharp_practice_problems.Problems
{
    public class TwoDtoOneD
    {
        public void convertTwoDtoOneD(int[,] arr)
        {
            int[] result = new int[arr.GetLength(0) * arr.GetLength(1)];
            int k = 0;
            for(int i=0;i<arr.GetLength(1); i++)
            {
                for(int j = 0; j < arr.GetLength(0); j++)
                {
                    result[k] = arr[j,i];
                    k++;
                }
            }
            for(int i = 0; i < result.Length; i++)
            {

                Console.WriteLine(result[i] + " ");
            }
        }
    }
}
