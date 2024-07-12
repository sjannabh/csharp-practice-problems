namespace csharp_practice_problems.Problems
{
    public class DoubleTheSearchElement
    {
        public void FindElement(int[] arr)
        {
            int result = 1;

            Array.Sort(arr);

            foreach (int i in arr) 
            {
                if (arr.Contains(result))
                {
                    result *= 2;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Output: " + result);
        }
    }
}
