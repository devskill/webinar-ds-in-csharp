using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            (int xDistance, int yDistance) distance = FindDistance(
                new Point { X = 5, Y = 9 }, 
                new Point { X = 11, Y = 17 }
            );

            Console.WriteLine($"Distance of X1 & X2 {distance.xDistance}");
            Console.WriteLine($"Distance of Y1 & Y2 {distance.yDistance}");
        }

        static (int, int) FindDistance(Point p1, Point p2)
        {
            return (Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
