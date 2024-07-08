namespace csharp_practice_problems.Problems
{
    public class EvenSumOddSum
    {
        public void sumEvenSumOdd(int[] arr)
        {
            int evenIndexSum = 0;
            int oddIndexSum = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if (i %2 == 0)
                {
                    evenIndexSum += arr[i];
                }
                else
                {
                    oddIndexSum += arr[i];
                }
            }
            Console.WriteLine("Sum of even indexes: " + evenIndexSum + " and Sum of odd indexes: " + oddIndexSum);
        }
    }
}
