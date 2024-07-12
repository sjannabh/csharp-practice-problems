namespace csharp_practice_problems.Problems
{
    public class FactorialLessThanNumber
    {
        public void FindFact(int n)
        {
            int fact = 1;
            int x = 2;
            
            while(fact <= n)
            {
                Console.Write(fact+ " ");
                fact = fact * x;
                x++;
            }
        }
    }
}
