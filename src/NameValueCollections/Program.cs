using System;
using System.Collections.Specialized;

namespace NameValueCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection configurations = new NameValueCollection();
            configurations.Add("SmtpHost", "smtp.gmail.com");
            configurations.Add("SmtpPort", "587");
            configurations.Add("SmtpUsername", "admin@gmail.com");
            configurations.Add("SmtpPassword", "IDontKnow");

            foreach (var key in configurations.AllKeys)
                Console.WriteLine($"Value of {key} is: {configurations[key]}");
        }
    }
}
