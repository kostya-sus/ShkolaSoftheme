using System;


namespace HW11_Printer
{
    public class ColourPrinter : Printer
    {
        public override void Print(string message)
        {
            
            base.Print(message);
        }

        public void Print(string message, ConsoleColor color)
        {
            
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}
