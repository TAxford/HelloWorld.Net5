using System;

namespace HelloWorld.Net5
{
    internal class Program
    {
        // starting point of our program
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Tim!");

            Console.Read();
            
        }
    }
}
