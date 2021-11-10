using System;

namespace Bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] numbers = { 0, 16, 104, 213 };
            Console.WriteLine("{0}   {1,8}   {2,5}   {3,5}",
                              "Value", "Binary", "Octal", "Hex");
            foreach (byte number in numbers)
            {
                Console.WriteLine("{0,5}   {1,8}   {2,5}   {3,5}",
                                  number, Convert.ToString(number, 2),
                                  Convert.ToString(number, 8),
                                  Convert.ToString(number, 16));
            }
        }
    }
}
