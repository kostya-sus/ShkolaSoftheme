using System;


namespace HW11_Printer
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string message)
        {
           
            base.Print(message);
        }

        public void Print(Image image)
        {
            Console.WriteLine(image.ToString());
        }
    }
}
