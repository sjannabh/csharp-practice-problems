namespace csharp_practice_problems.Problems
{
    public class ToeplitzOrNot
    {
        //Matrix in which each descending diagonal from left to right is constant, i.e., all elements in the diagonal are same.
        public bool IsToeplitz(int[,] arr)
        {
            bool flag = false;
            for(int i = 1; i < arr.GetLength(0); i++)
            {
                for(int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] != arr[i-1,j-1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
