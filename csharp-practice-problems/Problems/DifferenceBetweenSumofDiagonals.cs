namespace csharp_practice_problems.Problems
{
    public class DifferenceBetweenSumofDiagonals
    {
        public int getDifference(int[,] arr1)
        {
            int res1, res2;
            int diff = 0;
            SumOfDiagonals sumOfDiagonals = new SumOfDiagonals();
            sumOfDiagonals.diagnolsSum(arr1 , out res1, out res2);

            diff = Math.Abs(res1 - res2);

            return diff;
        }
    }
}
