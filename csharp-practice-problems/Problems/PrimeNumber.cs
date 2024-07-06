namespace csharp_practice_problems.Problems
{
    public class PrimeNumber
    {
        public static bool PrimeOrNot(int value)
        {
           
            if (value == 1) return false;
            if (value == 2) return true;
            

            for(int i=2; i <= value / 2; i++)
            {
                if(value % i == 0)
                {
                    return false;
                }
                
                
            }
            return true;
        }

        public string CheckPrime(int value)
        {
           bool result = PrimeNumber.PrimeOrNot(value);
            
            if (result) 
            {
                return "This is Prime Number";
            }
            return "This is not Prime Number";
        }
    }
}
