namespace csharp_practice_problems.Problems
{
    public class DistanceBetweenTwoPoints // sqrt((x2-x1)^2) + (y2-y1)^2)
    {
        public void PointDistance(double x1,double y1, double x2, double y2) //3,4,7,7
        {
            double result = 0;
            double numerator = Math.Pow((x2 - x1), 2);
            double denominator = Math.Pow((y2 - y1), 2);

            result = Math.Sqrt(numerator+denominator); // sqrt((7-3)^2 + (7-4)^2)

            Console.WriteLine("Distance between two points is: " + result);
        }
        
    }
}
