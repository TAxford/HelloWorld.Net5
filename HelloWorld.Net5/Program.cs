﻿using System;

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

            // implicit conversion
            int num = 12345678;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;
            string myFloatString = myFloat.ToString();

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString(); // "13.37"
            num.ToString();

            Console.WriteLine(myInt);

            string myParseString = "15";
            string myParseStringSecond = "13";
            // parsing string into an int
            int num1 = Int32.Parse(myParseString);
            int num2 = Int32.Parse(myParseStringSecond);
            int result = num1 + num2;

            Console.WriteLine(result);


            int age = 31;
            string name = "Alfonso";


            // 1. string concantenation
            Console.WriteLine("String Concantination");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");
            Console.Read();            
        }
    }
}
