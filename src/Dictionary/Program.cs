using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["Tareq Ahmed"] = 50;
            ages["Rafiq Mahmud"] = 77;

            foreach(var item in ages)
                Console.WriteLine($"Age of {item.Key}:{item.Value}");
        }
    }
}
