using System;

//using HW11_Printer;

namespace HW11_Printer
{
    public static class ExtensionMethod
    {
        public static void Print(this Printer printer, string[] strings)
        {
            foreach (var item in strings)
            {
                printer.Print(item);
            }
        }

        public static void Print(this ColourPrinter printer, string[] strings, ConsoleColor color)
        {
            foreach (var item in strings)
            {
                printer.Print(item, color);
            }
        }

        public static void Print(this PhotoPrinter printer, Image[] images)
        {
            foreach (var item in images)
            {
                printer.Print(item);
            }
        }
    }
}
