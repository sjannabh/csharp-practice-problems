namespace csharp_practice_problems.Problems
{
    public class SimpleIntrest
    {
        public void findSI(float p, float t, float r)
        {
            float result = 0f;

            result = (p * t * r) / 100;
            Console.WriteLine("Simple Intrest : "+result);
        } 
    }
}
