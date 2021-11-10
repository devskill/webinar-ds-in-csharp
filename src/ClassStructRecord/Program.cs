using System;

namespace ClassStructRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class
            Person person = new ();
            person.Name = "Rashed Ahmed";
            person.Age = 40;

            Person anotherPerson = new Person { Name = "Robin Hossain", Age = 32 };
            Console.WriteLine($"Person name: {person.Name}");
            Console.WriteLine($"Another person name: {anotherPerson.Name}");
            Console.WriteLine("---------------------------");

            person = anotherPerson;

            Console.WriteLine($"Person name: {person.Name}");
            Console.WriteLine($"Another person name: {anotherPerson.Name}");
            Console.WriteLine("---------------------------");

            person.Name = "Tareq Ahmed";

            Console.WriteLine($"Person name: {person.Name}");
            Console.WriteLine($"Another person name: {anotherPerson.Name}");
            Console.WriteLine("---------------------------");

            #endregion

            #region Struct
            Point p1 = new Point();
            p1.X = 5;
            p1.Y = 10;

            Point p2 = p1;

            Console.WriteLine($"P1.X {p1.X}");
            Console.WriteLine($"P1.Y {p1.Y}");
            Console.WriteLine($"P2.X {p2.X}");
            Console.WriteLine($"P2.Y {p2.Y}");
            Console.WriteLine("---------------------------");

            p2.X = 98;
            p2.Y = 99;

            Console.WriteLine($"P1.X {p1.X}");
            Console.WriteLine($"P1.Y {p1.Y}");
            Console.WriteLine($"P2.X {p2.X}");
            Console.WriteLine($"P2.Y {p2.Y}");
            Console.WriteLine("---------------------------");

            #endregion

            #region Record
            Point3D m1 = new Point3D();
            m1.X = 5;
            m1.Y = 10;
            m1.Z = 9;

            Point3D m2 = m1;

            Console.WriteLine($"M1.X {m1.X}");
            Console.WriteLine($"M1.Y {m1.Y}");
            Console.WriteLine($"M1.Z {m1.Z}");
            Console.WriteLine($"M2.X {m2.X}");
            Console.WriteLine($"M2.Y {m2.Y}");
            Console.WriteLine($"M2.Z {m2.Z}");
            Console.WriteLine("---------------------------");

            m2.X = 97;
            m2.Y = 98;
            m2.Z = 99;

            Console.WriteLine($"M1.X {m1.X}");
            Console.WriteLine($"M1.Y {m1.Y}");
            Console.WriteLine($"M1.Z {m1.Z}");
            Console.WriteLine($"M2.X {m2.X}");
            Console.WriteLine($"M2.Y {m2.Y}");
            Console.WriteLine($"M2.Z {m2.Z}");
            if(m1 == m2)
                Console.WriteLine("M1 & M2 are equal");
            else
                Console.WriteLine("M1 & M2 are not equal");

            Console.WriteLine("---------------------------");

            Point3D m3 = new Point3D { X = 97, Y = 98, Z = 99};

            if (m1 == m3)
                Console.WriteLine("M1 & M3 are equal");
            else
                Console.WriteLine("M1 & M3 are not equal");


            #endregion
        }
    }
}
