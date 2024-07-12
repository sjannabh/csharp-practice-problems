namespace csharp_practice_problems.Problems
{
    public class MaximumProduct
    {
        public void FindMax(int[] arr)
        {
            Array.Sort(arr);
            int product1 = arr[0] * arr[1];
            int product2 = arr[arr.Length - 1] * arr[arr.Length - 2];

            if(product1 > product2)
            {
                Console.WriteLine("Maximum Product pair in the array is: " + arr[0] + " , " + arr[1]);
            }
            else
            {
                Console.WriteLine("Maximum Product pair in the array is: " + arr[arr.Length-1] + " , " + arr[arr.Length - 2]);

            }
        }
    }
}
