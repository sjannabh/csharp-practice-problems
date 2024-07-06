namespace csharp_practice_problems.Problems
{
    public class RightCircularRotation
    {
        public void RightCircle(int[] arr) //[1,2,3,4,5]
        {
            int temp = arr[arr.Length - 1]; // temp = 5
            for(int i = arr.Length - 1; i > 0; i--)  // i from 4 to 1
            {
                arr[i] = arr[i-1]; // arr[5] = arr[4]
            }
            arr[0] = temp;

            Console.Write(string.Join(" ",arr));  
            Console.WriteLine();
        }
    }
}
