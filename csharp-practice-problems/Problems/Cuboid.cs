namespace csharp_practice_problems.Problems
{
    public class Cuboid
    {
        public void volumeAndSurfaceArea(int length, int width, int height)
        {
            int area = length * width * height;
            int surfaceArea = 2 * length * width + 2 * width * height + 2 * height * length;

            Console.WriteLine("Area of cuboid is: " + area);
            Console.WriteLine("Surface area of the cuboid is: " + surfaceArea);
        }
    }
}
