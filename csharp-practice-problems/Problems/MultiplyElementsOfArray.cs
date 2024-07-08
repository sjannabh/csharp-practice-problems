namespace csharp_practice_problems.Problems
{
    public class MultiplyElementsOfArray
    {
        public void elementsProduct(int[] arr)
        {
            int product = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine("Product of array elements is: "+product);
        }
    }
}
