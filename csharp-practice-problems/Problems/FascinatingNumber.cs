namespace csharp_practice_problems.Problems
{
    public class FascinatingNumber
    {
        //When a number( 3 digits or more ) is multiplied by 2 and 3, and when both these products are concatenated
        //with the original number, then it results in all digits from 1 to 9 present exactly once.
        //There could be any number of zeros and are ignored. 
        public bool IsFascinating(int number)
        {
            if (number < 100)
            {
                return false;
            }

            int p1 = number * 2;
            int p2 = number * 3;

            string str = number.ToString() + p1.ToString() + p2.ToString();

            //Boolean.Parse(str);
            //int res = Int32.Parse(str);
            //int temp = Convert.ToInt32(str);

            HashSet<int> hset = new HashSet<int>();

            foreach (int i in str)
            {
                if (i == 0)
                    return false;
                if (hset.Contains(i))
                {
                    return false;
                }
                else
                {
                    hset.Add(i);
                }
            }

            if (hset.Count != 9) { return false; }

            return true;
        }

    }
}
