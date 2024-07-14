namespace csharp_practice_problems.Problems
{
    public class LowerCaseToUpperCase
    {
        public void lowerToUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public void lowToUp(string str)
        {
            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++) 
            {
                if (chars[i] >= 'a' & chars[i] <= 'z') 
                {
                    chars[i] = (char)(chars[i] - 'a' + 'A');
                }
            }
            Console.WriteLine(string.Join("", chars));

        }

        public void lowerToUp(string str)
        {
            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'a' && chars[i] <= 'z')
                {
                    chars[i] = (char)((int)chars[i] & (~(1 << 5)));
                }
            }
            Console.WriteLine(string.Join("", chars));
        }

        public void lowToUpper(string str)
        {
            char[] chars = str.ToCharArray();

            for(int i=0;i<chars.Length; i++)
            {
                if (chars[i] >= 'a' & chars[i] <= 'z')
                {
                    chars[i] = (char)((int)chars[i] - 32);
                }
                else
                {
                    chars[i] = chars[i];
                }
            }
            Console.WriteLine(string.Join("", chars));
        }
    }
}
