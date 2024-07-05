using System.ComponentModel.DataAnnotations;

namespace csharp_practice_problems.Problems
{
    public class LeftCircularRotation
    {
        public void LeftCircle(int[] arr)
        {
            int temp = arr[0];

            for(int i = 1; i <= arr.Length - 1; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
                
            }

        }
    }
}
