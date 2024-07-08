namespace csharp_practice_problems.Problems
{
    public class SwappingTwoNumbers
    {
        public void swapping(int a, int b)
        {
            Console.WriteLine("Original values of a and b: " + a + "," + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping the values of a and b: " + a + "," + b);
        }
    }
}
