namespace csharp_practice_problems.Problems
{
    public class EarliestRepeatingCharacter
    {
        public void getEarliest(string str)
        {
            Dictionary<char,int> kval = new Dictionary<char,int>();

            foreach(char ch in str)
            {
                if (!kval.ContainsKey(ch))
                {
                    kval.Add(ch, 1);
                }
                else
                {
                    Console.WriteLine("Earliest Repeating Character is: " + ch);
                    break;
                }
            }
         }
    }
}
