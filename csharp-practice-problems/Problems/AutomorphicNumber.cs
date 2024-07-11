namespace csharp_practice_problems.Problems
{
    public class AutomorphicNumber
    {
        // Number is called automorphic number if and  only if its square ends in the same digits as the number itself.
        public void IsAutomorphic(int num)
        {
            int numSquare = num * num;

            int givenNum = num;
            double resNum = 0;
            int count = 0;
            Console.WriteLine("Given number: " + num);
            while(num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine("Square of a number: " + numSquare);
            
           resNum = (numSquare % Math.Pow(10,count));
                
            
            Console.WriteLine("Resultant Number: " + resNum);
            if(resNum == givenNum)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }
        }
    }
}
