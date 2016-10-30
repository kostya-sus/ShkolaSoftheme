using System;


namespace HW11_Printer
{
    public class Printer
    {
        public virtual void Print(string mesaage)
        {
           Console.WriteLine("Print :" + mesaage);
        }
    }
}
