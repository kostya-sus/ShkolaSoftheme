using System;


namespace HW13_memory
{
    class Program
    {
        static void Main(string[] args)
        {
            var holderBase = new ResourceHolderBase();
            var holderDerived = new ResourceHolderDerived();
            //first dispose
            holderDerived.Dispose();
            holderBase.Dispose();
            //one more dispose
            holderDerived.Dispose();
            holderBase.Dispose();
            Console.ReadKey();
        }
    }
}

