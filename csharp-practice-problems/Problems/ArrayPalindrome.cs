namespace csharp_practice_problems.Problems
{
    public class ArrayPalindrome
    {
        public void IsArrayPalindrome(int[] arr) //5
        {
            int n = arr.Length -1/ 2; // 2
            bool flag = false;

            for(int i = 0; i < n; i++)  // 0,1
            {
                if (arr[i] == arr[arr.Length -1 - i]) // 0-4,1-3
                {
                    flag = true;
                    continue;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Given array is a palindrome");
            }
            else
            {
                Console.WriteLine("Given array is not a palindrome");
            }
        }
    }
}
