namespace csharp_practice_problems.Problems
{
    public class CountCharacterOccurences
    {
        public void countOccurence(string str)
        {
            char res = ' ';
            int count = 0;

            Dictionary<char, int> kValues = new Dictionary<char, int>();

            foreach (char c in str) 
            {
                if (!kValues.ContainsKey(c))
                {
                    kValues.Add(c, 1);
                }
                kValues[c]++;
            }

            foreach(var item in kValues)
            {
                if(item.Value > count)
                {
                    count = item.Value;
                    res = item.Key;
                }
            }

            Console.WriteLine(res.ToString() + " occurs " + count + " times in the string");

        }

    }
}
