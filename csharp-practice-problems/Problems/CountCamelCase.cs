namespace csharp_practice_problems.Problems
{
    public class CountCamelCase
    {
        // camel case character is defined as the number of uppercase characters in the given string
        public void countCamel(string str)
        {
            char[] chars = str.ToCharArray();
            int count = 0;

            foreach (char c in chars) 
            {
                if(c == char.ToUpper(c))
                {
                    count++;
                }
            }
            Console.WriteLine("Count of camel case characters in given string: "+count);
        }
    }
}
