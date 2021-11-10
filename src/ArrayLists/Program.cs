using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList someItems = new ArrayList { "Mango", "Banana", 50.5, true, DateTime.Now };

            foreach(var item in someItems)
                Console.WriteLine(item);
        }
    }
}
