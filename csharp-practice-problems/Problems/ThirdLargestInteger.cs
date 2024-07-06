namespace csharp_practice_problems.Problems
{
    public class ThirdLargestInteger
    {
        public void thirdLargest(int[] arr)
        {
            int biggest = 0;
            int secondBiggest = 0;
            int thirdBiggest = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggest)
                {
                    thirdBiggest = secondBiggest;
                    secondBiggest = biggest;
                    biggest = arr[i];
                }
                else if (arr[i] > secondBiggest && biggest != arr[i])
                {
                    thirdBiggest = secondBiggest;
                    secondBiggest = arr[i];
                }
                else if(arr[i] > thirdBiggest && arr[i] != secondBiggest && biggest != arr[i])
                {
                    thirdBiggest = arr[i];
                }
            }
            Console.WriteLine("Third largest integer of an array is: " + thirdBiggest);
        }
    }
}
