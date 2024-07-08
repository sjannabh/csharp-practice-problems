namespace csharp_practice_problems.Problems
{
    public class CharacterVowelorNot
    {
        public void IsVowel(char character)
        {
            character = Char.ToLower(character);
            if(character=='a' || character =='e' ||character=='i' || character=='o' ||character == 'u')
            {
                Console.WriteLine("Given character is vowel");
            }
            else
            {
                Console.WriteLine("Given character is consonent");

            }
        }
    }
}
