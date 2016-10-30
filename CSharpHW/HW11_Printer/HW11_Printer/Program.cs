using System;


namespace HW11_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            ColourPrinter colourPrinter = new ColourPrinter();
            PhotoPrinter photoPrinter = new PhotoPrinter();

            Console.WriteLine("Method Print of Printer!");
            printer.Print("message");

            Console.WriteLine("\nMethod Print of ColourPrinter!");
            colourPrinter.Print("message");

            Console.WriteLine("\nMethod Print  of PhotoPrinter!");
            photoPrinter.Print("message");

            Console.WriteLine("\nMethod Print(string arg, ConsoleColor color)  of PhotoPrinter!");
            colourPrinter.Print("colour message", ConsoleColor.Green);

            Console.WriteLine("\nMethod Print(Image) of PhotoPrinter!");
            photoPrinter.Print(new Image() { Name = "photo.jpeg" });

            Console.ReadLine();
        }
    }
}
