namespace csharp_practice_problems.Problems
{
    public class SolidAndHollowSquare
    {
        public void sAndh(int n)
        {
            //Solid Pattern
            Console.WriteLine("Solid Pattern:");
            for(int i=0;i<n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Hollow Pattern:");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i==0 || i== n-1 || j==0|| j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
