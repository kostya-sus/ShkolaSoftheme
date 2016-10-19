using System;

namespace HW1_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Kostya";

            System.Console.ForegroundColor = ConsoleColor.Yellow; 

            System.Console.WriteLine("Hello {0}", name);
            System.Console.ReadKey();
        }
    }
}
