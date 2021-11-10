using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[10];
            int[] weights = new int[] { 59, 72, 81};
            ages[0] = 72;

            int[,] coordinates = new int[10, 6];
            coordinates[0, 1] = 5;
            coordinates[0, 2] = 9;
            coordinates[2, 2] = 7;

            int[][] results = new int[5][];
            results[0] = new int[3];
            results[1] = new int[5];
            results[2] = new int[9];
            results[3] = new int[10];
            results[4] = new int[2];

            results[0][0] = 60;
            results[0][1] = 90;
            results[1][0] = 70;

            Console.WriteLine($"Coordinate value at 0, 1 = {coordinates[0, 1]}");
            Console.WriteLine($"Coordinate value at 0, 2 = {coordinates[0, 2]}");
            Console.WriteLine($"Coordinate value at 2, 2 = {coordinates[2, 2]}");

            Console.WriteLine($"Result value at 0, 0 = {results[0][0]}");
            Console.WriteLine($"Result value at 0, 1 = {results[0][1]}");
            Console.WriteLine($"Result value at 1, 0 = {results[1][0]}");
        }
    }
}
