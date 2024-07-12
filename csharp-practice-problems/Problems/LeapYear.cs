namespace csharp_practice_problems.Problems
{
    public class LeapYear
    {
        public void IsLeap(int year)
        {
            bool flag = false;
            if(year % 400 == 0 || year %4 == 0 & year%100 != 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
    }
}
