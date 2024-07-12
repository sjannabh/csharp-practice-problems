namespace csharp_practice_problems.Problems
{
    public class AverageOfStreamNumbers
    {
        public void PrintAvgStream(float[] arr)
        {
            float sum = 0;
            double average = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                average = sum / (i+1);
                Console.WriteLine("Average of " + (i + 1) + " numbers is: " + average.ToString("#.##"));
            }
        }
    }
}
