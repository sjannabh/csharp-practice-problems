namespace csharp_practice_problems.Problems
{
    public class HalfDiamond
    {
        public void halfDiamondPattern(int n)
        {

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            //reverse
            for(int i=n-2; i >= 0; i--)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
