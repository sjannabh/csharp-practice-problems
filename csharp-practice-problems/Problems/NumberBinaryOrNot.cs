namespace csharp_practice_problems.Problems
{
    public class NumberBinaryOrNot
    {
        public void CheckBinary(int num)
        {
            bool flag = false;
            if (num <= 1)
            {
                flag = false;
                Console.WriteLine("Number is binary: "+flag);
            }
            else if(num > 1)
            {
               while(num > 0)
               {
                    if (num % 10 == 0 || num % 10 == 1)
                    {
                        flag = true;
                        num = num / 10;
                        continue;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
               }
            }
            Console.WriteLine("Number is binary: "+flag);
        }
    }
}
