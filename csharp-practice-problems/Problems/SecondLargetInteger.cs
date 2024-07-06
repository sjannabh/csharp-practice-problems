namespace csharp_practice_problems.Problems
{
    public class SecondLargetInteger
    {
        public void secondLargest(int[] arr) //95,98,34,51,77
        {
            int biggest = 0;
            int secondBiggest = 0;
            

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggest)
                {
                    secondBiggest = biggest;
                    biggest = arr[i];
                }
                else if (arr[i] > secondBiggest && biggest != arr[i])
                {
                    secondBiggest = arr[i];
                }
            }
            Console.WriteLine("Second largest integer of an array is: " + secondBiggest);
        }
    }
}
