using System;
using System.Linq;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a password between or equal to 7 or 12 characters. It must contain at least 1 lowercase letter, at least 1 uppercase letter, and at least one exclamation point (!)");
            string password = Console.ReadLine();

            int Passlength = password.Length;
            bool upper = password.Any(char.IsUpper);
            bool lower = password.Any(char.IsLower);
            bool exclaim = password.Contains("!");

            if (Passlength >= 7 &&
                Passlength <= 12 &&
                upper &&
                lower &&
                exclaim)

            { Console.WriteLine("Password valid and accepted"); }

            else

            { Console.WriteLine("Error"); }

        }
    }
}