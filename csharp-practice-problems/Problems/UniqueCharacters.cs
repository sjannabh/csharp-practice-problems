namespace csharp_practice_problems.Problems
{
    public class UniqueCharacters
    {
        public void uniCharacter(string str)
        {
            Dictionary<char, int> unichar = new Dictionary<char, int>();

            foreach (char c in str) 
            {
                if (!unichar.ContainsKey(c))
                {
                    unichar.Add(c, 1);
                }
            }

            int count = unichar.Count;
            Console.WriteLine("Count of unique characters is: " + count);
        }
    }
}
