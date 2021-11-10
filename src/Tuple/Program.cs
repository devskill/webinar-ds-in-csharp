using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            (int xDistance, int yDistance) distance = FindDistance(5, 9, 11, 17);

            Console.WriteLine($"Distance of X1 & X2 {distance.xDistance}");
            Console.WriteLine($"Distance of Y1 & Y2 {distance.yDistance}");
        }

        static (int, int) FindDistance(int x1, int y1, int x2, int y2)
        {
            return (Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        }
    }
}
