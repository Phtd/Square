using System;

namespace Square
{
    class Program
    {

        static void Main(string[] args)
        {

            Square omkreds = new Square(7, 11, 12); // Gives the variables a, b and c values
            Console.WriteLine(omkreds.Omkreds()); // Calls the function Omkreds and display it on the screen
            Console.WriteLine(omkreds.Area()); // Calls the function Area, and display it on the screen
            Console.ReadKey(); // makes it so you have to press a key in order to proceed in the program

        }

    }
}
