namespace csharp_practice_problems.Problems
{
    public class AddEvensInArray
    {
        public void evenSum(int[] arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
        }

         public int Sure(int a)
        {
            a += 10;
             return a; 
        }
    }


    
}
