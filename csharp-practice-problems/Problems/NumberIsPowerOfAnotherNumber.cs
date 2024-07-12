namespace csharp_practice_problems.Problems
{
    public class NumberIsPowerOfAnotherNumber
    {
        public bool isPower(int x, int y)
        {
            if (x == 1)
                return (y == 1);

            int pow = 1;
            while (pow < y)
                pow = pow * x;

           
            return (pow == y);
        }
    }
}
