using System;

using HW11_Printer;



namespace HW11_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            ColourPrinter colourPrinter = new ColourPrinter();
            PhotoPrinter photoPrinter = new PhotoPrinter();

            string[] strings = { "Message1", "Message2", "Message3" };

            Image[] images = { new Image() {Name = "picture1.jpeg"},
                               new Image() {Name = "picture2.jpeg"},
                               new Image() {Name = "picture2.jpeg"}
                             };

            Console.WriteLine("Сalling a extension method of Printer!");
            printer.Print(strings);

            Console.WriteLine("\nСalling a extension method of ColourPrinter!");
            colourPrinter.Print(strings, ConsoleColor.DarkGreen);

            Console.WriteLine("\nСalling a extension method of PhotoPrinter!");
            photoPrinter.Print(images);

            Console.ReadLine();
        }
    }
}
