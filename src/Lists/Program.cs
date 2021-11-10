using System;
using System.Collections.Generic;

namespace Webinar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> teacherNames = new List<string>();
            teacherNames.Add("Jalaluddin");
            teacherNames.Add("Sadman Sakib");

            var studentNames = new List<string> { "Hasan Ahmed", "Tareq Mahmud" };

            teacherNames.Remove("Sadman Sakib");

            studentNames[0] = "Ahmed Hasan";

            Console.WriteLine(studentNames[0]);
        }
    }
}
