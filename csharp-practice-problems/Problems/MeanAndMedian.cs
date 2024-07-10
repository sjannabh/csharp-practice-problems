namespace csharp_practice_problems.Problems
{
    public class MeanAndMedian
    {
        public void FindMandM(int[] arr)
        {
            Array.Sort(arr);
            float mean = 0;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            mean = ((float)sum / (float)arr.Length);
            Console.WriteLine("Mean of the given array is: " + mean);

            float median = 0f;
            if(arr.Length % 2 == 0)
            {
                median = (float) (arr[(arr.Length - 1)/2] + arr[(arr.Length)/2]) / 2;
            }
            else
            {
                median = arr[(arr.Length / 2)];
            }

            Console.WriteLine("Median of given array is: " + median);
        }
    }
}
