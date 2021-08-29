using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ||  ||");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" \\\\()// ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("//(__)\\\\");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("||    ||");

            Console.ResetColor();
        }
    }
}
