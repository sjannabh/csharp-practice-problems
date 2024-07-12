namespace csharp_practice_problems.Problems
{
    public class OddTimesOccurence
    {
        public void oddTimes(int[] arr)
        {
            Dictionary<int, int> kValues = new Dictionary<int, int>();
            int result = 0;

            foreach (int i in arr) 
            {
                if (!kValues.ContainsKey(i))
                {
                    kValues.Add(i, 1);
                }
                kValues[i]++;
            }

            foreach(var item in kValues)
            {
                if(item.Value % 2 ! == 0)
                {
                    result = item.Key;
                    break;
                }
            }
            Console.WriteLine("The number that occurred odd number of times is: " + result);
        }

    }
}
