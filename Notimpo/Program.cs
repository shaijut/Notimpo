using System;

namespace Notimpo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Environment.GetEnvironmentVariable("INPUT_FIRST_NAME");
            var lastName = Environment.GetEnvironmentVariable("INPUT_LAST_NAME");

            Console.WriteLine(firstName + " SPACE " + lastName);
            Console.WriteLine("Hello World from Notimpo :)");
        }
    }
}
