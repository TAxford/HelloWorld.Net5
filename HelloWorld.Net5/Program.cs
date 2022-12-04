using System;

namespace HelloWorld.Net5
{
    // Class names like ClientActivity
    internal class Program
    {
        // starting point of our program
        // Method name like CalculateValue
        // method arguments like firstNumber
        static void Main(string[] args)
        {
            //changes text color
            Console.ForegroundColor = ConsoleColor.Gray;
            //changes background of text
            Console.BackgroundColor = ConsoleColor.Red;
            //allows background change of entire console
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Tim!");

            Console.Read();
            
        }
    }
}
