namespace csharp_practice_problems.Problems
{
    public class AngleBetweenHandM
    {
        public void findAngle(int h, int m)
        {
            if (h > 12)
            {
                h = h % 12;
            }


            // Rotation angle of hours hand
            // 12 hours = 360 degrees
            // 1 hour = 30 degrees
            // 60 min = 30 degrees
            // 1 min = 0.5 degrees

            double hoursAngle = (h * 30) + (m * 0.5);

            // Rotation angle of minutes hand
            //60 min = 360 degrees
            //1 min = 6 degrees
            double minsAngle = (m * 6);

            double totalAngle = Math.Abs(hoursAngle - minsAngle);

            Console.WriteLine("Angle between hour and minutes hand of a clock is: " + totalAngle);

        }
    }
}
