namespace csharp_practice_problems.Problems
{
    public class AlternateElementsofArray
    {
        public void alternate(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i%2 == 0)
                {
                    Console.Write(arr[i]+ " ");
                }
            }
        }
    }
}
