namespace csharp_practice_problems.Problems
{
    public class DiceProblem
    {
        public void guessOppNum(int n)
        {
            int total = 7;
            int guessNum = total - n;

            Console.WriteLine("Number on opposite side is: " + guessNum);
        }
    }
}
