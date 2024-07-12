namespace csharp_practice_problems.Problems
{
    public class ArraySortedOrNot
    {
        public bool IsSorted(int[] arr) 
        {
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] > arr[i])
                {
                    return false;
                    
                }
              
            }
            return true;
        }
    }
}
