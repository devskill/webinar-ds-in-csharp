using System;

namespace AnonymousObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic person = GetData();
            Console.WriteLine($"Name of person: {person.Name}");
            Console.WriteLine($"Age of person: {person.Age}");
            Console.WriteLine($"Weight of person: {person.Weight}");
        }

        static object GetData()
        {
            return new { Name = "Tareq Ahmed", Age = 29, Weight = 56.9 };
        }
    }
}
