namespace csharp_practice_problems.Problems
{
    public class ArmstrongNumber
    {
        public void isArmstrong(int num)
        {
            int givenNum = num;
            int count = 0;
            int sum = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }

            num = givenNum;

            for(int i = 0; i < count; i++)
            {
                int n = num % 10;
                sum +=(int) Math.Pow(n ,count);
                num = num / 10;
            }

            if(sum == givenNum)
            {
                Console.WriteLine("This is an Armstrong Number");
            }
            else
            {
                Console.WriteLine("This is not an Armstrong Number");
            }
        }
    }
}
