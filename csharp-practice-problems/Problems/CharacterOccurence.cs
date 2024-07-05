namespace csharp_practice_problems.Problems
{
    public class CharacterOccurence
    {
        public void CountOccurrence(string str)
        {
            Dictionary<char, int> OccurenceCount = new Dictionary<char, int>();
            foreach (char c in str) 
            {
                if (!OccurenceCount.ContainsKey(c))
                {
                    OccurenceCount.Add(c, 1);
                }
                else
                {
                    OccurenceCount[c]++;
                }
            }

            foreach (var item in OccurenceCount) 
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}
