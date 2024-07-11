namespace csharp_practice_problems.Problems
{
    public class ExtractIntegersFromString
    {
        public void IntegerExtract(char[] str)
        {
            int n = str.Length;
            String curr = "";
            for(int i = 0; i < n; i++)
            {
                if (str[i]-'0' >=0 && str[i] - '0' <= 9)
                {
                    curr += str[i];
                }
                else
                {
                    if(curr.Length > 0)
                    {
                        Console.Write(int.Parse(curr) + " ");
                        curr = "";
                    }
                }
            }
            if(curr.Length > 0)
            {
                Console.Write(int.Parse(curr) + " ");
                curr = "";
            }
        }
    }
}
