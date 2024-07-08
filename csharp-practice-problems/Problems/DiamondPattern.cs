namespace csharp_practice_problems.Problems
{
    public class DiamondPattern
    {
        public void pattern(int n)
        {
            int gaps = n - 1;
            for (int k = 0; k < n; k++)
            {
                //printing spaces
                for (int i = 0; i < gaps; i++)
                {
                    Console.Write(" ");
                }
                //printing stars
                for (int j = 0; j <= k; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                gaps--;
            }

            //reverse
            for (int k = n; k > 0; k--) //n=5
            {
                //printing spaces
                for (int i = 0; i <= gaps; i++)
                {
                    Console.Write(" ");
                }
                //printing stars
                for (int j = 0; j < k; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                gaps++;
            }

        }
    }
}
