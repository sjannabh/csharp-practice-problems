namespace csharp_practice_problems.Problems
{
    public class DisplayLongestName
    {
        public void displayLong(string[] arr)
        {
            string res = "";
            int n = arr.Length;
            int len = 0;

            for(int i = 0; i < n; i++)
            {
                if (arr[i].Length >= len)
                {
                    len = arr[i].Length;
                    res = arr[i];
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }

    
}
