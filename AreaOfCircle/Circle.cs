using System.Data;

namespace Helpers
{
    public class Circle
    {
        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double Diamter(double radius)
        {
            return radius * 2;
        }
    }
}